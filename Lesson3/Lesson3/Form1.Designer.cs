
namespace Lesson3
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.読込ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Jan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itm = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.income = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Communicate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month,
            this.day,
            this.price,
            this.itm,
            this.income,
            this.comment});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(828, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 読込ToolStripMenuItem
            // 
            this.読込ToolStripMenuItem.Name = "読込ToolStripMenuItem";
            this.読込ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.読込ToolStripMenuItem.Text = "読込";
            this.読込ToolStripMenuItem.Click += new System.EventHandler(this.読込ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.読込ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(849, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jan,
            this.Feb,
            this.Mar,
            this.Apr,
            this.May,
            this.Jun,
            this.Jul,
            this.Aug,
            this.Sep,
            this.Oct,
            this.Nov,
            this.Dec});
            this.dataGridView2.Location = new System.Drawing.Point(12, 318);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 21;
            this.dataGridView2.Size = new System.Drawing.Size(828, 45);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "月別支出集計";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "費目別支出集計";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.food,
            this.Communicate,
            this.Transport,
            this.Other});
            this.dataGridView3.Location = new System.Drawing.Point(11, 412);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 21;
            this.dataGridView3.Size = new System.Drawing.Size(823, 53);
            this.dataGridView3.TabIndex = 6;
            // 
            // Jan
            // 
            this.Jan.HeaderText = "1月";
            this.Jan.Name = "Jan";
            this.Jan.Width = 65;
            // 
            // Feb
            // 
            this.Feb.HeaderText = "2月";
            this.Feb.Name = "Feb";
            this.Feb.Width = 65;
            // 
            // Mar
            // 
            this.Mar.HeaderText = "3月";
            this.Mar.Name = "Mar";
            this.Mar.Width = 65;
            // 
            // Apr
            // 
            this.Apr.HeaderText = "4月";
            this.Apr.Name = "Apr";
            this.Apr.Width = 65;
            // 
            // May
            // 
            this.May.HeaderText = "5月";
            this.May.Name = "May";
            this.May.Width = 65;
            // 
            // Jun
            // 
            this.Jun.HeaderText = "6月";
            this.Jun.Name = "Jun";
            this.Jun.Width = 65;
            // 
            // Jul
            // 
            this.Jul.HeaderText = "7月";
            this.Jul.Name = "Jul";
            this.Jul.Width = 65;
            // 
            // Aug
            // 
            this.Aug.HeaderText = "8月";
            this.Aug.Name = "Aug";
            this.Aug.Width = 65;
            // 
            // Sep
            // 
            this.Sep.HeaderText = "9月";
            this.Sep.Name = "Sep";
            this.Sep.Width = 65;
            // 
            // Oct
            // 
            this.Oct.HeaderText = "10月";
            this.Oct.Name = "Oct";
            this.Oct.Width = 65;
            // 
            // Nov
            // 
            this.Nov.HeaderText = "11月";
            this.Nov.Name = "Nov";
            this.Nov.Width = 65;
            // 
            // Dec
            // 
            this.Dec.HeaderText = "12月";
            this.Dec.Name = "Dec";
            this.Dec.Width = 65;
            // 
            // month
            // 
            this.month.HeaderText = "月";
            this.month.Name = "month";
            this.month.Width = 40;
            // 
            // day
            // 
            this.day.HeaderText = "日";
            this.day.Name = "day";
            this.day.Width = 40;
            // 
            // price
            // 
            this.price.HeaderText = "金額";
            this.price.Name = "price";
            // 
            // itm
            // 
            this.itm.HeaderText = "費目";
            this.itm.Items.AddRange(new object[] {
            "食費",
            "通信費",
            "交通費",
            "その他"});
            this.itm.Name = "itm";
            this.itm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itm.Width = 150;
            // 
            // income
            // 
            this.income.HeaderText = "収入/支出";
            this.income.Items.AddRange(new object[] {
            "収入",
            "支出"});
            this.income.Name = "income";
            this.income.Width = 130;
            // 
            // comment
            // 
            this.comment.HeaderText = "コメント";
            this.comment.Name = "comment";
            this.comment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.comment.Width = 320;
            // 
            // food
            // 
            this.food.HeaderText = "食費";
            this.food.Name = "food";
            // 
            // Communicate
            // 
            this.Communicate.HeaderText = "通信費";
            this.Communicate.Name = "Communicate";
            // 
            // Transport
            // 
            this.Transport.HeaderText = "交通費";
            this.Transport.Name = "Transport";
            // 
            // Other
            // 
            this.Other.HeaderText = "その他";
            this.Other.Name = "Other";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 469);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Budget";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 読込ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apr;
        private System.Windows.Forms.DataGridViewTextBoxColumn May;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dec;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewComboBoxColumn itm;
        private System.Windows.Forms.DataGridViewComboBoxColumn income;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn food;
        private System.Windows.Forms.DataGridViewTextBoxColumn Communicate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other;
    }
}

