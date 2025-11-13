namespace FuckUCodeGUI {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.FUC_executable = new System.Windows.Forms.TextBox();
            this.FUC_e_openfile = new System.Windows.Forms.Button();
            this.analyze_openfile = new System.Windows.Forms.Button();
            this.analyze_directory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.verbose = new System.Windows.Forms.CheckBox();
            this.only_summary = new System.Windows.Forms.CheckBox();
            this.output_md = new System.Windows.Forms.CheckBox();
            this.skipindex = new System.Windows.Forms.CheckBox();
            this.topest_files = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prob_per_file = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lang_combobox = new System.Windows.Forms.ComboBox();
            this.other_lang = new System.Windows.Forms.TextBox();
            this.excepted_directory = new System.Windows.Forms.ListBox();
            this.excepted_open_file = new System.Windows.Forms.Button();
            this.excepted_path_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enable_topest_file = new System.Windows.Forms.CheckBox();
            this.enable_prpf = new System.Windows.Forms.CheckBox();
            this.result_box = new System.Windows.Forms.TextBox();
            this.start_analyze = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.enable_cmd = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.topest_files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob_per_file)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FuckUCode 主程序";
            // 
            // FUC_executable
            // 
            this.FUC_executable.AllowDrop = true;
            this.FUC_executable.Location = new System.Drawing.Point(153, 13);
            this.FUC_executable.Name = "FUC_executable";
            this.FUC_executable.Size = new System.Drawing.Size(220, 24);
            this.FUC_executable.TabIndex = 1;
            this.FUC_executable.Text = "fuck-u-code.exe";
            this.FUC_executable.DragDrop += new System.Windows.Forms.DragEventHandler(this.file_DragDrop);
            this.FUC_executable.DragEnter += new System.Windows.Forms.DragEventHandler(this.excepted_directory_DragEnter);
            // 
            // FUC_e_openfile
            // 
            this.FUC_e_openfile.Font = new System.Drawing.Font("幼圆", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FUC_e_openfile.Location = new System.Drawing.Point(379, 14);
            this.FUC_e_openfile.Name = "FUC_e_openfile";
            this.FUC_e_openfile.Size = new System.Drawing.Size(33, 23);
            this.FUC_e_openfile.TabIndex = 2;
            this.FUC_e_openfile.Text = "...";
            this.FUC_e_openfile.UseVisualStyleBackColor = true;
            this.FUC_e_openfile.Click += new System.EventHandler(this.FUC_e_openfile_Click);
            // 
            // analyze_openfile
            // 
            this.analyze_openfile.Font = new System.Drawing.Font("幼圆", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.analyze_openfile.Location = new System.Drawing.Point(379, 42);
            this.analyze_openfile.Name = "analyze_openfile";
            this.analyze_openfile.Size = new System.Drawing.Size(33, 23);
            this.analyze_openfile.TabIndex = 5;
            this.analyze_openfile.Text = "...";
            this.analyze_openfile.UseVisualStyleBackColor = true;
            this.analyze_openfile.Click += new System.EventHandler(this.analyze_openfile_Click);
            // 
            // analyze_directory
            // 
            this.analyze_directory.AllowDrop = true;
            this.analyze_directory.Location = new System.Drawing.Point(153, 41);
            this.analyze_directory.Name = "analyze_directory";
            this.analyze_directory.Size = new System.Drawing.Size(220, 24);
            this.analyze_directory.TabIndex = 4;
            this.analyze_directory.DragDrop += new System.Windows.Forms.DragEventHandler(this.file_DragDrop);
            this.analyze_directory.DragEnter += new System.Windows.Forms.DragEventHandler(this.excepted_directory_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "分析目录";
            // 
            // verbose
            // 
            this.verbose.AutoSize = true;
            this.verbose.Location = new System.Drawing.Point(9, 102);
            this.verbose.Name = "verbose";
            this.verbose.Size = new System.Drawing.Size(125, 19);
            this.verbose.TabIndex = 6;
            this.verbose.Text = "显示详细报告";
            this.verbose.UseVisualStyleBackColor = true;
            // 
            // only_summary
            // 
            this.only_summary.AutoSize = true;
            this.only_summary.Location = new System.Drawing.Point(9, 77);
            this.only_summary.Name = "only_summary";
            this.only_summary.Size = new System.Drawing.Size(93, 19);
            this.only_summary.TabIndex = 6;
            this.only_summary.Text = "只看总结";
            this.only_summary.UseVisualStyleBackColor = true;
            // 
            // output_md
            // 
            this.output_md.AutoSize = true;
            this.output_md.Location = new System.Drawing.Point(9, 127);
            this.output_md.Name = "output_md";
            this.output_md.Size = new System.Drawing.Size(141, 19);
            this.output_md.TabIndex = 6;
            this.output_md.Text = "输出为MarkDown";
            this.output_md.UseVisualStyleBackColor = true;
            // 
            // skipindex
            // 
            this.skipindex.AutoSize = true;
            this.skipindex.Location = new System.Drawing.Point(9, 152);
            this.skipindex.Name = "skipindex";
            this.skipindex.Size = new System.Drawing.Size(197, 19);
            this.skipindex.TabIndex = 6;
            this.skipindex.Text = "跳过 index.js/ts 文件";
            this.skipindex.UseVisualStyleBackColor = true;
            // 
            // topest_files
            // 
            this.topest_files.AllowDrop = true;
            this.topest_files.Location = new System.Drawing.Point(130, 52);
            this.topest_files.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.topest_files.Name = "topest_files";
            this.topest_files.ReadOnly = true;
            this.topest_files.Size = new System.Drawing.Size(67, 24);
            this.topest_files.TabIndex = 7;
            this.topest_files.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "个文件";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "个问题";
            // 
            // prob_per_file
            // 
            this.prob_per_file.AllowDrop = true;
            this.prob_per_file.Location = new System.Drawing.Point(130, 26);
            this.prob_per_file.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.prob_per_file.Name = "prob_per_file";
            this.prob_per_file.ReadOnly = true;
            this.prob_per_file.Size = new System.Drawing.Size(67, 24);
            this.prob_per_file.TabIndex = 7;
            this.prob_per_file.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "显示语言";
            // 
            // lang_combobox
            // 
            this.lang_combobox.FormattingEnabled = true;
            this.lang_combobox.Items.AddRange(new object[] {
            "zh-CN",
            "en-US",
            "ru-RU",
            "其它"});
            this.lang_combobox.Location = new System.Drawing.Point(83, 171);
            this.lang_combobox.MaxDropDownItems = 20;
            this.lang_combobox.Name = "lang_combobox";
            this.lang_combobox.Size = new System.Drawing.Size(121, 23);
            this.lang_combobox.TabIndex = 8;
            this.lang_combobox.SelectedIndexChanged += new System.EventHandler(this.lang_combobox_SelectedIndexChanged);
            // 
            // other_lang
            // 
            this.other_lang.Location = new System.Drawing.Point(210, 170);
            this.other_lang.Name = "other_lang";
            this.other_lang.Size = new System.Drawing.Size(77, 24);
            this.other_lang.TabIndex = 4;
            this.other_lang.Visible = false;
            // 
            // excepted_directory
            // 
            this.excepted_directory.AllowDrop = true;
            this.excepted_directory.FormattingEnabled = true;
            this.excepted_directory.HorizontalExtent = 4;
            this.excepted_directory.HorizontalScrollbar = true;
            this.excepted_directory.ItemHeight = 15;
            this.excepted_directory.Location = new System.Drawing.Point(3, 44);
            this.excepted_directory.Name = "excepted_directory";
            this.excepted_directory.ScrollAlwaysVisible = true;
            this.excepted_directory.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.excepted_directory.Size = new System.Drawing.Size(443, 154);
            this.excepted_directory.TabIndex = 9;
            this.excepted_directory.DragDrop += new System.Windows.Forms.DragEventHandler(this.excepted_directory_DragDrop);
            this.excepted_directory.DragEnter += new System.Windows.Forms.DragEventHandler(this.excepted_directory_DragEnter);
            this.excepted_directory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.excepted_directory_KeyDown);
            // 
            // excepted_open_file
            // 
            this.excepted_open_file.Font = new System.Drawing.Font("幼圆", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.excepted_open_file.Location = new System.Drawing.Point(413, 18);
            this.excepted_open_file.Name = "excepted_open_file";
            this.excepted_open_file.Size = new System.Drawing.Size(33, 23);
            this.excepted_open_file.TabIndex = 5;
            this.excepted_open_file.Text = "...";
            this.excepted_open_file.UseVisualStyleBackColor = true;
            this.excepted_open_file.Click += new System.EventHandler(this.excepted_open_file_Click);
            // 
            // excepted_path_input
            // 
            this.excepted_path_input.AllowDrop = true;
            this.excepted_path_input.Location = new System.Drawing.Point(6, 18);
            this.excepted_path_input.Name = "excepted_path_input";
            this.excepted_path_input.Size = new System.Drawing.Size(401, 24);
            this.excepted_path_input.TabIndex = 4;
            this.excepted_path_input.DragDrop += new System.Windows.Forms.DragEventHandler(this.file_DragDrop);
            this.excepted_path_input.DragEnter += new System.Windows.Forms.DragEventHandler(this.excepted_directory_DragEnter);
            this.excepted_path_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.excepted_path_input_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.excepted_directory);
            this.groupBox1.Controls.Add(this.excepted_path_input);
            this.groupBox1.Controls.Add(this.excepted_open_file);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 219);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "排除目录或文件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.other_lang);
            this.groupBox2.Controls.Add(this.lang_combobox);
            this.groupBox2.Controls.Add(this.prob_per_file);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.topest_files);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.skipindex);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.output_md);
            this.groupBox2.Controls.Add(this.enable_topest_file);
            this.groupBox2.Controls.Add(this.enable_prpf);
            this.groupBox2.Controls.Add(this.verbose);
            this.groupBox2.Controls.Add(this.only_summary);
            this.groupBox2.Location = new System.Drawing.Point(476, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 200);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "其它选项";
            // 
            // enable_topest_file
            // 
            this.enable_topest_file.AutoSize = true;
            this.enable_topest_file.Location = new System.Drawing.Point(9, 52);
            this.enable_topest_file.Name = "enable_topest_file";
            this.enable_topest_file.Size = new System.Drawing.Size(125, 19);
            this.enable_topest_file.TabIndex = 6;
            this.enable_topest_file.Text = "显示最烂的前";
            this.enable_topest_file.UseVisualStyleBackColor = true;
            this.enable_topest_file.CheckedChanged += new System.EventHandler(this.enable_topest_file_CheckedChanged);
            // 
            // enable_prpf
            // 
            this.enable_prpf.AutoSize = true;
            this.enable_prpf.Location = new System.Drawing.Point(9, 27);
            this.enable_prpf.Name = "enable_prpf";
            this.enable_prpf.Size = new System.Drawing.Size(125, 19);
            this.enable_prpf.TabIndex = 6;
            this.enable_prpf.Text = "每个文件显示";
            this.enable_prpf.UseVisualStyleBackColor = true;
            this.enable_prpf.CheckedChanged += new System.EventHandler(this.enable_prpf_CheckedChanged);
            // 
            // result_box
            // 
            this.result_box.Location = new System.Drawing.Point(6, 23);
            this.result_box.Multiline = true;
            this.result_box.Name = "result_box";
            this.result_box.ReadOnly = true;
            this.result_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result_box.Size = new System.Drawing.Size(764, 157);
            this.result_box.TabIndex = 12;
            this.result_box.DoubleClick += new System.EventHandler(this.result_box_DoubleClick);
            // 
            // start_analyze
            // 
            this.start_analyze.Location = new System.Drawing.Point(632, 218);
            this.start_analyze.Name = "start_analyze";
            this.start_analyze.Size = new System.Drawing.Size(156, 72);
            this.start_analyze.TabIndex = 13;
            this.start_analyze.Text = "开始分析";
            this.start_analyze.UseVisualStyleBackColor = true;
            this.start_analyze.Click += new System.EventHandler(this.satrt_analyze_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.result_box);
            this.groupBox3.Location = new System.Drawing.Point(12, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 197);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "结果";
            // 
            // enable_cmd
            // 
            this.enable_cmd.AutoSize = true;
            this.enable_cmd.Location = new System.Drawing.Point(485, 246);
            this.enable_cmd.Name = "enable_cmd";
            this.enable_cmd.Size = new System.Drawing.Size(141, 19);
            this.enable_cmd.TabIndex = 6;
            this.enable_cmd.Text = "启用命令行窗口";
            this.enable_cmd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.start_analyze);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.analyze_openfile);
            this.Controls.Add(this.analyze_directory);
            this.Controls.Add(this.enable_cmd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FUC_e_openfile);
            this.Controls.Add(this.FUC_executable);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FuckUCodeGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topest_files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob_per_file)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FUC_executable;
        private System.Windows.Forms.Button FUC_e_openfile;
        private System.Windows.Forms.Button analyze_openfile;
        private System.Windows.Forms.TextBox analyze_directory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox verbose;
        private System.Windows.Forms.CheckBox only_summary;
        private System.Windows.Forms.CheckBox output_md;
        private System.Windows.Forms.CheckBox skipindex;
        private System.Windows.Forms.NumericUpDown topest_files;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown prob_per_file;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox lang_combobox;
        private System.Windows.Forms.TextBox other_lang;
        private System.Windows.Forms.ListBox excepted_directory;
        private System.Windows.Forms.Button excepted_open_file;
        private System.Windows.Forms.TextBox excepted_path_input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox enable_topest_file;
        private System.Windows.Forms.CheckBox enable_prpf;
        private System.Windows.Forms.TextBox result_box;
        private System.Windows.Forms.Button start_analyze;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox enable_cmd;
    }
}

