namespace Aps8.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNovaCidade = new Button();
            lsvCidades = new ListView();
            Id = new ColumnHeader();
            Nome = new ColumnHeader();
            lblNome = new Label();
            txbNome = new TextBox();
            btnExcluirCidade = new Button();
            SuspendLayout();
            // 
            // btnNovaCidade
            // 
            btnNovaCidade.Location = new Point(12, 51);
            btnNovaCidade.Name = "btnNovaCidade";
            btnNovaCidade.Size = new Size(84, 23);
            btnNovaCidade.TabIndex = 0;
            btnNovaCidade.Text = "Nova Cidade";
            btnNovaCidade.UseVisualStyleBackColor = true;
            btnNovaCidade.Click += btnNovaCidade_Click;
            // 
            // lsvCidades
            // 
            lsvCidades.Columns.AddRange(new ColumnHeader[] { Id, Nome });
            lsvCidades.Location = new Point(12, 108);
            lsvCidades.Name = "lsvCidades";
            lsvCidades.Size = new Size(704, 330);
            lsvCidades.TabIndex = 3;
            lsvCidades.UseCompatibleStateImageBehavior = false;
            lsvCidades.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 350;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 350;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(14, 13);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(60, 10);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(135, 23);
            txbNome.TabIndex = 5;
            // 
            // btnExcluirCidade
            // 
            btnExcluirCidade.Location = new Point(102, 51);
            btnExcluirCidade.Name = "btnExcluirCidade";
            btnExcluirCidade.Size = new Size(93, 23);
            btnExcluirCidade.TabIndex = 6;
            btnExcluirCidade.Text = "Excluir Cidade";
            btnExcluirCidade.UseVisualStyleBackColor = true;
            btnExcluirCidade.Click += btnExcluirCidade_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 450);
            Controls.Add(btnExcluirCidade);
            Controls.Add(txbNome);
            Controls.Add(lblNome);
            Controls.Add(lsvCidades);
            Controls.Add(btnNovaCidade);
            Name = "Form1";
            Text = "QualyAir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovaCidade;
        private ListView lsvCidades;
        private ColumnHeader Id;
        private ColumnHeader Nome;
        private Label lblNome;
        private TextBox txbNome;
        private Button btnExcluirCidade;
    }
}