namespace ExemploAsyncAwait
{
    partial class Form1
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
            this.btnSync = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(13, 13);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(161, 23);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Executar função Sincrona";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(180, 13);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(189, 23);
            this.btnAsync.TabIndex = 1;
            this.btnAsync.Text = "Executar função assincrona";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.BtnAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 51);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnSync);
            this.Name = "Form1";
            this.Text = "Exemplo Async Await";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnAsync;
    }
}

