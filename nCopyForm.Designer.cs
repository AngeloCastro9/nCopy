namespace CopiaEmissor
{
    partial class nCopyForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nCopyForm));
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfigFile = new System.Windows.Forms.TextBox();
            this.btnOpenFolder2 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(425, 169);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(60, 23);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.Text = "...";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(15, 172);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(382, 20);
            this.txtSourcePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Config file:";
            // 
            // txtConfigFile
            // 
            this.txtConfigFile.Location = new System.Drawing.Point(15, 68);
            this.txtConfigFile.Name = "txtConfigFile";
            this.txtConfigFile.Size = new System.Drawing.Size(382, 20);
            this.txtConfigFile.TabIndex = 1;
            // 
            // btnOpenFolder2
            // 
            this.btnOpenFolder2.Location = new System.Drawing.Point(425, 65);
            this.btnOpenFolder2.Name = "btnOpenFolder2";
            this.btnOpenFolder2.Size = new System.Drawing.Size(60, 23);
            this.btnOpenFolder2.TabIndex = 2;
            this.btnOpenFolder2.Text = "...";
            this.btnOpenFolder2.UseVisualStyleBackColor = true;
            this.btnOpenFolder2.Click += new System.EventHandler(this.btnOpenFolder2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(303, 246);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 295);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(666, 33);
            this.progressBar1.TabIndex = 7;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(611, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 23);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // nCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 347);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfigFile);
            this.Controls.Add(this.btnOpenFolder2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.btnOpenFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nCopyForm";
            this.Text = "nCopy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfigFile;
        private System.Windows.Forms.Button btnOpenFolder2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnHelp;
    }
}

