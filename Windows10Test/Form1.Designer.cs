namespace Windows10Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser11 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxNavigatedURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser12 = new System.Windows.Forms.WebBrowser();
            this.webBrowser13 = new System.Windows.Forms.WebBrowser();
            this.webBrowser21 = new System.Windows.Forms.WebBrowser();
            this.webBrowser22 = new System.Windows.Forms.WebBrowser();
            this.webBrowser23 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser11
            // 
            this.webBrowser11.Location = new System.Drawing.Point(30, 99);
            this.webBrowser11.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser11.Name = "webBrowser11";
            this.webBrowser11.ScrollBarsEnabled = false;
            this.webBrowser11.Size = new System.Drawing.Size(253, 185);
            this.webBrowser11.TabIndex = 1;
            this.webBrowser11.Url = new System.Uri("file:///F:/DataDocsPhotosPlus/Downloads/openweatherapi-modified.htm", System.UriKind.Absolute);
            this.webBrowser11.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBoxNavigatedURL
            // 
            this.textBoxNavigatedURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNavigatedURL.Location = new System.Drawing.Point(68, 76);
            this.textBoxNavigatedURL.Name = "textBoxNavigatedURL";
            this.textBoxNavigatedURL.Size = new System.Drawing.Size(786, 13);
            this.textBoxNavigatedURL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(33, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // webBrowser12
            // 
            this.webBrowser12.Location = new System.Drawing.Point(321, 99);
            this.webBrowser12.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser12.Name = "webBrowser12";
            this.webBrowser12.ScrollBarsEnabled = false;
            this.webBrowser12.Size = new System.Drawing.Size(253, 185);
            this.webBrowser12.TabIndex = 5;
            this.webBrowser12.Url = new System.Uri("file:///F:/DataDocsPhotosPlus/Downloads/openweatherapi-annapolis.htm", System.UriKind.Absolute);
            // 
            // webBrowser13
            // 
            this.webBrowser13.Location = new System.Drawing.Point(601, 99);
            this.webBrowser13.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser13.Name = "webBrowser13";
            this.webBrowser13.ScrollBarsEnabled = false;
            this.webBrowser13.Size = new System.Drawing.Size(253, 185);
            this.webBrowser13.TabIndex = 6;
            this.webBrowser13.Url = new System.Uri("file:///F:/DataDocsPhotosPlus/Downloads/openweatherapi-annapolis.htm", System.UriKind.Absolute);
            // 
            // webBrowser21
            // 
            this.webBrowser21.Location = new System.Drawing.Point(30, 323);
            this.webBrowser21.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser21.Name = "webBrowser21";
            this.webBrowser21.ScrollBarsEnabled = false;
            this.webBrowser21.Size = new System.Drawing.Size(253, 185);
            this.webBrowser21.TabIndex = 7;
            this.webBrowser21.Url = new System.Uri("file:///F:/DataDocsPhotosPlus/Downloads/openweatherapi-annapolis.htm", System.UriKind.Absolute);
            // 
            // webBrowser22
            // 
            this.webBrowser22.Location = new System.Drawing.Point(321, 323);
            this.webBrowser22.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser22.Name = "webBrowser22";
            this.webBrowser22.ScrollBarsEnabled = false;
            this.webBrowser22.Size = new System.Drawing.Size(253, 185);
            this.webBrowser22.TabIndex = 8;
            this.webBrowser22.Url = new System.Uri("file:///F:/DataDocsPhotosPlus/Downloads/openweatherapi-annapolis.htm", System.UriKind.Absolute);
            // 
            // webBrowser23
            // 
            this.webBrowser23.Location = new System.Drawing.Point(601, 323);
            this.webBrowser23.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser23.Name = "webBrowser23";
            this.webBrowser23.ScrollBarsEnabled = false;
            this.webBrowser23.Size = new System.Drawing.Size(253, 185);
            this.webBrowser23.TabIndex = 9;
            this.webBrowser23.Url = new System.Uri("file:///F:/DataDocsPhotosPlus/Downloads/openweatherapi-annapolis.htm", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(879, 607);
            this.Controls.Add(this.webBrowser23);
            this.Controls.Add(this.webBrowser22);
            this.Controls.Add(this.webBrowser21);
            this.Controls.Add(this.webBrowser13);
            this.Controls.Add(this.webBrowser12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNavigatedURL);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser11);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxNavigatedURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser12;
        private System.Windows.Forms.WebBrowser webBrowser13;
        private System.Windows.Forms.WebBrowser webBrowser21;
        private System.Windows.Forms.WebBrowser webBrowser22;
        private System.Windows.Forms.WebBrowser webBrowser23;
    }
}

