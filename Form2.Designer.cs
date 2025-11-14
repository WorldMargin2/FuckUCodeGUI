namespace FuckUCodeGUI {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textbox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox_result
            // 
            this.textbox_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_result.Location = new System.Drawing.Point(0, 0);
            this.textbox_result.Multiline = true;
            this.textbox_result.Name = "textbox_result";
            this.textbox_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textbox_result.Size = new System.Drawing.Size(849, 500);
            this.textbox_result.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 500);
            this.Controls.Add(this.textbox_result);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_result;
    }
}