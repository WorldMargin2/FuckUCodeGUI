using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuckUCodeGUI {
    public partial class Form1 : Form {

        string lang = "zh-CN";

        public Form1() {
            InitializeComponent();
        }


        void startAnalyze() {

            start_analyze.Enabled = false;
            if (!File.Exists(FUC_executable.Text)) {
                MessageBox.Show("请选择正确的fuck-u-code可执行文件");
                return;
            } else if (!Directory.Exists(analyze_directory.Text)) {
                MessageBox.Show("请选择正确的目录");
                return;
            }

            //--verbose -v  显示详细报告
            //--top N   -t  最烂的前 N 个文件
            //--issues N  -i  每文件显示 N 个问题
            //--summary -s  只看总结，不看过程
            //--markdown -m  输出 Markdown 格式报告
            //--lang -l  报告语言(zh - CN / en - US / ru - RU)
            //--exclude -e  排除指定目录或文件
            //--skipindex
            string args = "";

            args+="analyze \"" +analyze_directory.Text +"\"";

            if (verbose.Checked) {
                args += " -v";
            }
            if(enable_topest_file.Checked) {
                args += " -t " + topest_files.Text;
            }
            if (enable_prpf.Checked) {
                args += " -i " + prob_per_file.Text;
            }

            if(only_summary.Checked) {
                args += " -s";
            }
            if (output_md.Checked) {
                args += " -m";
            }
            if (skipindex.Checked) {
                args += " --skipindex";
            }

            if (excepted_directory.Items.Count > 0) {
                foreach (string s in excepted_directory.Items) {
                    args += " -e \"" + s + "\"";
                }
            }

            if (lang_combobox.SelectedIndex != -1) {
                args += " -l ";
                if(lang_combobox.SelectedItem.ToString() == "其它") {
                    args += other_lang.Text;
                } else {
                    args += lang_combobox.SelectedItem.ToString();
                }
            }


            if (enable_cmd.Checked) {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.UseShellExecute = false;
                psi.Arguments = $"/c  \"{FUC_executable.Text} {args}\" & pause";
                psi.FileName = "cmd.exe";
                psi.CreateNoWindow = false;
                
                var p = Process.Start(psi);
            }

            Task.Run(() => {
                var process = new Process();
                process.StartInfo.FileName = FUC_executable.Text;
                process.StartInfo.Arguments = args;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                process.Start();
                //逐行读取
                result_box.Invoke(new Action(() => {
                    result_box.Clear();
                }));
                List<string> tmp = new List<string>();
                string _tmp;
                bool lastLine_brank = false;
                do {
                    _tmp = process.StandardOutput.ReadLine();
                    if (!lastLine_brank && _tmp == "") {
                        lastLine_brank = true;
                        continue;
                    } else if (_tmp != "") {
                        lastLine_brank = false;
                    } else if (_tmp == "") {
                        lastLine_brank = true;
                    }
                    if (_tmp != null && !_tmp.StartsWith("\u001b[K")) {
                        tmp.Add(_tmp);
                    }
                } while (_tmp != null);
                result_box.Invoke(new Action(() => {
                    foreach (string s in tmp) {
                        result_box.AppendText(s + "\r\n");
                    }
                    start_analyze.Enabled = true;
                    MessageBox.Show("分析完成");
                }));
            });

        }

        private void lang_combobox_SelectedIndexChanged(object sender, EventArgs e) {
            if (lang_combobox.SelectedItem.ToString() == "其它") {
                other_lang.Visible = true;
            } else {
                other_lang.Visible = false;
                lang = lang_combobox.SelectedItem.ToString();
            }
        }

        private void FUC_e_openfile_Click(object sender, EventArgs e) {
            //打开文件
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "可执行文件|*.exe";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK) {
                FUC_executable.Text = ofd.FileName;
            }

        }
        private void analyze_openfile_Click(object sender, EventArgs e) {
            //打开目录
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) {
                analyze_directory.Text = fbd.SelectedPath;
            }
        }

        //通用文件选择（textbox）
        private void file_DragDrop(object sender, DragEventArgs e) {
            string p = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            var control=sender as Control;
            if (control != null) {
                control.Text = p;
            }
        }

        private void excepted_directory_DragDrop(object sender, DragEventArgs e) {
            String[] fileNames = (String[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string p in fileNames) {
                if (excepted_directory.Items.Contains(p)) {
                    continue;
                }
                excepted_directory.Items.Add(p);
            }
            
        }

        //通用拖入事件（textbox，listbox）
        private void excepted_directory_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.All;

            }else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void excepted_directory_KeyDown(object sender, KeyEventArgs e) {
            //删除多项
            if(e.KeyCode == Keys.Delete && excepted_directory.SelectedIndices.Count > 0) {
                List<string> selected = new List<string>();
                selected= excepted_directory.SelectedItems.Cast<string>().ToList();
                foreach (string p in selected) {
                    excepted_directory.Items.Remove(p);
                }
            }
            
        }

        private void excepted_open_file_Click(object sender, EventArgs e) {
            //选择目录或文件
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "|*.*";
            ofd.Multiselect = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK) {
                foreach (string p in ofd.FileNames) {
                    if (excepted_directory.Items.Contains(p)) {
                        continue;
                    }
                    excepted_directory.Items.Add(p);
                }
            }
        }





        private void excepted_path_input_KeyDown(object sender, KeyEventArgs e) {
            if(Keys.Enter == e.KeyCode) {
                if (excepted_path_input.Text != "") {
                    if (excepted_directory.Items.Contains(excepted_path_input.Text)) {
                        MessageBox.Show("已存在");
                        return;
                    }
                    if(File.Exists(excepted_path_input.Text)|| Directory.Exists(excepted_path_input.Text)) {
                        
                        excepted_directory.Items.Add(excepted_path_input.Text.Replace("\"", "").Replace("'", ""));
                        excepted_path_input.Text = "";
                    } else {
                        MessageBox.Show("路径不存在");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }


        private void enable_topest_file_CheckedChanged(object sender, EventArgs e) {
            topest_files.ReadOnly = !enable_topest_file.Checked;
        }


        private void enable_prpf_CheckedChanged(object sender, EventArgs e) {
           prob_per_file.ReadOnly = !enable_prpf.Checked;
        }

        private void result_box_DoubleClick(object sender, EventArgs e) {
            //双击用大窗口显示
            if (result_box.Text != "") {
                Form2 f2 = new Form2(result_box.Text);
                f2.ShowDialog();
            }
        }

        private void satrt_analyze_Click(object sender, EventArgs e) {
            startAnalyze();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/WorldMargin2/FuckUCodeGUI");
        }
    }
}
