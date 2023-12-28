
namespace ClassBaiTap2
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt01 = new System.Windows.Forms.Button();
            this.bt02 = new System.Windows.Forms.Button();
            this.bt03 = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.bt04 = new System.Windows.Forms.Button();
            this.bt05 = new System.Windows.Forms.Button();
            this.bt06 = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.bt07 = new System.Windows.Forms.Button();
            this.bt08 = new System.Windows.Forms.Button();
            this.bt09 = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.bt00 = new System.Windows.Forms.Button();
            this.btClean = new System.Windows.Forms.Button();
            this.btResult = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.lbExpression = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dfToolStripMenuItem
            // 
            this.dfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem1,
            this.bToolStripMenuItem});
            this.dfToolStripMenuItem.Name = "dfToolStripMenuItem";
            this.dfToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.dfToolStripMenuItem.Text = "menu màu";
            this.dfToolStripMenuItem.Click += new System.EventHandler(this.dfToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuItem1.Text = "Thay đổi màu sắc";
            this.aToolStripMenuItem1.Click += new System.EventHandler(this.aToolStripMenuItem1_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bToolStripMenuItem.Text = "Thay đổi phông chữ";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbExpression, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbResult, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 329);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.bt01, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt02, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt03, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btAdd, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt04, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt05, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt06, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btMinus, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt07, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bt08, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.bt09, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btMul, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.bt00, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btClean, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btResult, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btDivision, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(292, 245);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            this.tableLayoutPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // bt01
            // 
            this.bt01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt01.Location = new System.Drawing.Point(5, 5);
            this.bt01.Margin = new System.Windows.Forms.Padding(5);
            this.bt01.Name = "bt01";
            this.bt01.Size = new System.Drawing.Size(63, 51);
            this.bt01.TabIndex = 0;
            this.bt01.Text = "1";
            this.bt01.UseVisualStyleBackColor = true;
            this.bt01.Click += new System.EventHandler(this.btNumberClick);
            this.bt01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseDown);
            this.bt01.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // bt02
            // 
            this.bt02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt02.Location = new System.Drawing.Point(78, 5);
            this.bt02.Margin = new System.Windows.Forms.Padding(5);
            this.bt02.Name = "bt02";
            this.bt02.Size = new System.Drawing.Size(63, 51);
            this.bt02.TabIndex = 1;
            this.bt02.Text = "2";
            this.bt02.UseVisualStyleBackColor = true;
            this.bt02.Click += new System.EventHandler(this.bt02_Click);
            this.bt02.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // bt03
            // 
            this.bt03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt03.Location = new System.Drawing.Point(151, 5);
            this.bt03.Margin = new System.Windows.Forms.Padding(5);
            this.bt03.Name = "bt03";
            this.bt03.Size = new System.Drawing.Size(63, 51);
            this.bt03.TabIndex = 2;
            this.bt03.Text = "3";
            this.bt03.UseVisualStyleBackColor = true;
            this.bt03.Click += new System.EventHandler(this.bt03_Click);
            this.bt03.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btAdd.Location = new System.Drawing.Point(224, 5);
            this.btAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(63, 51);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            this.btAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // bt04
            // 
            this.bt04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt04.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt04.Location = new System.Drawing.Point(5, 66);
            this.bt04.Margin = new System.Windows.Forms.Padding(5);
            this.bt04.Name = "bt04";
            this.bt04.Size = new System.Drawing.Size(63, 51);
            this.bt04.TabIndex = 4;
            this.bt04.Text = "4";
            this.bt04.UseVisualStyleBackColor = true;
            this.bt04.Click += new System.EventHandler(this.bt04_Click);
            this.bt04.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // bt05
            // 
            this.bt05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt05.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt05.Location = new System.Drawing.Point(78, 66);
            this.bt05.Margin = new System.Windows.Forms.Padding(5);
            this.bt05.Name = "bt05";
            this.bt05.Size = new System.Drawing.Size(63, 51);
            this.bt05.TabIndex = 5;
            this.bt05.Text = "5";
            this.bt05.UseVisualStyleBackColor = true;
            this.bt05.Click += new System.EventHandler(this.bt05_Click);
            this.bt05.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // bt06
            // 
            this.bt06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt06.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt06.Location = new System.Drawing.Point(151, 66);
            this.bt06.Margin = new System.Windows.Forms.Padding(5);
            this.bt06.Name = "bt06";
            this.bt06.Size = new System.Drawing.Size(63, 51);
            this.bt06.TabIndex = 6;
            this.bt06.Text = "6";
            this.bt06.UseVisualStyleBackColor = true;
            this.bt06.Click += new System.EventHandler(this.bt06_Click);
            this.bt06.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // btMinus
            // 
            this.btMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btMinus.Location = new System.Drawing.Point(224, 66);
            this.btMinus.Margin = new System.Windows.Forms.Padding(5);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(63, 51);
            this.btMinus.TabIndex = 7;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            this.btMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // bt07
            // 
            this.bt07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt07.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt07.Location = new System.Drawing.Point(5, 127);
            this.bt07.Margin = new System.Windows.Forms.Padding(5);
            this.bt07.Name = "bt07";
            this.bt07.Size = new System.Drawing.Size(63, 51);
            this.bt07.TabIndex = 8;
            this.bt07.Text = "7";
            this.bt07.UseVisualStyleBackColor = true;
            this.bt07.Click += new System.EventHandler(this.bt07_Click);
            this.bt07.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // bt08
            // 
            this.bt08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt08.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt08.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt08.Location = new System.Drawing.Point(78, 127);
            this.bt08.Margin = new System.Windows.Forms.Padding(5);
            this.bt08.Name = "bt08";
            this.bt08.Size = new System.Drawing.Size(63, 51);
            this.bt08.TabIndex = 9;
            this.bt08.Text = "8";
            this.bt08.UseVisualStyleBackColor = true;
            this.bt08.Click += new System.EventHandler(this.bt08_Click);
            this.bt08.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // bt09
            // 
            this.bt09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt09.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt09.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt09.Location = new System.Drawing.Point(151, 127);
            this.bt09.Margin = new System.Windows.Forms.Padding(5);
            this.bt09.Name = "bt09";
            this.bt09.Size = new System.Drawing.Size(63, 51);
            this.bt09.TabIndex = 10;
            this.bt09.Text = "9";
            this.bt09.UseVisualStyleBackColor = true;
            this.bt09.Click += new System.EventHandler(this.bt09_Click);
            this.bt09.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // btMul
            // 
            this.btMul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btMul.Location = new System.Drawing.Point(224, 127);
            this.btMul.Margin = new System.Windows.Forms.Padding(5);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(63, 51);
            this.btMul.TabIndex = 11;
            this.btMul.Text = "x";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            this.btMul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // bt00
            // 
            this.bt00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt00.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt00.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt00.Location = new System.Drawing.Point(5, 188);
            this.bt00.Margin = new System.Windows.Forms.Padding(5);
            this.bt00.Name = "bt00";
            this.bt00.Size = new System.Drawing.Size(63, 52);
            this.bt00.TabIndex = 12;
            this.bt00.Text = "0";
            this.bt00.UseVisualStyleBackColor = true;
            this.bt00.Click += new System.EventHandler(this.bt00_Click);
            this.bt00.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // btClean
            // 
            this.btClean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btClean.Location = new System.Drawing.Point(78, 188);
            this.btClean.Margin = new System.Windows.Forms.Padding(5);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(63, 52);
            this.btClean.TabIndex = 13;
            this.btClean.Text = "C";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            this.btClean.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // btResult
            // 
            this.btResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btResult.Location = new System.Drawing.Point(151, 188);
            this.btResult.Margin = new System.Windows.Forms.Padding(5);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(63, 52);
            this.btResult.TabIndex = 14;
            this.btResult.Text = "=";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            this.btResult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // btDivision
            // 
            this.btDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btDivision.Location = new System.Drawing.Point(224, 188);
            this.btDivision.Margin = new System.Windows.Forms.Padding(5);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(63, 52);
            this.btDivision.TabIndex = 15;
            this.btDivision.Text = "/";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            this.btDivision.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt01_MouseUp);
            // 
            // lbExpression
            // 
            this.lbExpression.AutoSize = true;
            this.lbExpression.BackColor = System.Drawing.Color.Yellow;
            this.lbExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpression.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbExpression.Location = new System.Drawing.Point(0, 3);
            this.lbExpression.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.lbExpression.Name = "lbExpression";
            this.lbExpression.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.lbExpression.Size = new System.Drawing.Size(295, 36);
            this.lbExpression.TabIndex = 1;
            this.lbExpression.Text = "Biểu thức";
            this.lbExpression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbExpression.Click += new System.EventHandler(this.lbExpression_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.Color.Lime;
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbResult.Location = new System.Drawing.Point(0, 42);
            this.lbResult.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.lbResult.Size = new System.Drawing.Size(295, 36);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "Kết quả";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbResult.Click += new System.EventHandler(this.lbResult_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 353);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy tính của ***";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bt01;
        private System.Windows.Forms.Button bt02;
        private System.Windows.Forms.Button bt03;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button bt04;
        private System.Windows.Forms.Button bt05;
        private System.Windows.Forms.Button bt06;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button bt07;
        private System.Windows.Forms.Button bt08;
        private System.Windows.Forms.Button bt09;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button bt00;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.Label lbExpression;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

