namespace AhDung
{
    partial class FmMDI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMDI));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnNewChild = new System.Windows.Forms.ToolStripButton();
            this.btnNewNormal = new System.Windows.Forms.ToolStripButton();
            this.btnPopupFromItem = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.colorPicker1 = new AhDung.ColorPicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rb3D = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbShowDialog = new System.Windows.Forms.RadioButton();
            this.rbShow = new System.Windows.Forms.RadioButton();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbSingleStyle = new System.Windows.Forms.ComboBox();
            this.cmb3DStyle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPopupFromTextBox = new System.Windows.Forms.TextBox();
            this.btnPopupFromButton = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewChild,
            this.btnNewNormal,
            this.btnPopupFromItem,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(1161, 33);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // btnNewChild
            // 
            this.btnNewChild.Image = ((System.Drawing.Image)(resources.GetObject("btnNewChild.Image")));
            this.btnNewChild.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnNewChild.Name = "btnNewChild";
            this.btnNewChild.Size = new System.Drawing.Size(146, 28);
            this.btnNewChild.Text = "开子窗体测试";
            this.btnNewChild.Click += new System.EventHandler(this.btnNewChild_Click);
            // 
            // btnNewNormal
            // 
            this.btnNewNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNewNormal.Image")));
            this.btnNewNormal.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnNewNormal.Name = "btnNewNormal";
            this.btnNewNormal.Size = new System.Drawing.Size(164, 28);
            this.btnNewNormal.Text = "开普通窗体测试";
            this.btnNewNormal.Click += new System.EventHandler(this.btnNewNormal_Click);
            // 
            // btnPopupFromItem
            // 
            this.btnPopupFromItem.Image = ((System.Drawing.Image)(resources.GetObject("btnPopupFromItem.Image")));
            this.btnPopupFromItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnPopupFromItem.Name = "btnPopupFromItem";
            this.btnPopupFromItem.Size = new System.Drawing.Size(164, 28);
            this.btnPopupFromItem.Text = "从工具栏项弹出";
            this.btnPopupFromItem.Click += new System.EventHandler(this.btnPopupFromItem_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.IsLink = true;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(175, 28);
            this.helpToolStripButton.Text = "written by AhDung";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 800);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1161, 31);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(46, 24);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.colorPicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txbPopupFromTextBox);
            this.panel1.Controls.Add(this.btnPopupFromButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 270);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "颜色选择器Demo:";
            // 
            // colorPicker1
            // 
            this.colorPicker1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorPicker1.DropDownHeight = 1;
            this.colorPicker1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorPicker1.FormattingEnabled = true;
            this.colorPicker1.IntegralHeight = false;
            this.colorPicker1.Location = new System.Drawing.Point(165, 164);
            this.colorPicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(109, 29);
            this.colorPicker1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "悬停此处显示Tip";
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbResult);
            this.groupBox2.Location = new System.Drawing.Point(830, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(314, 248);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DialogResult";
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(9, 30);
            this.txbResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(294, 206);
            this.txbResult.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.cmbColor);
            this.groupBox1.Controls.Add(this.cmbSingleStyle);
            this.groupBox1.Controls.Add(this.cmb3DStyle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(356, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(465, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "弹出窗体选项";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbSingle);
            this.panel3.Controls.Add(this.rb3D);
            this.panel3.Controls.Add(this.rbNone);
            this.panel3.Location = new System.Drawing.Point(130, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 40);
            this.panel3.TabIndex = 4;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(192, 9);
            this.rbSingle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(87, 22);
            this.rbSingle.TabIndex = 1;
            this.rbSingle.Tag = "FixedSingle";
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            this.rbSingle.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // rb3D
            // 
            this.rb3D.AutoSize = true;
            this.rb3D.Checked = true;
            this.rb3D.Location = new System.Drawing.Point(105, 9);
            this.rb3D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb3D.Name = "rb3D";
            this.rb3D.Size = new System.Drawing.Size(51, 22);
            this.rb3D.TabIndex = 1;
            this.rb3D.TabStop = true;
            this.rb3D.Tag = "Fixed3D";
            this.rb3D.Text = "3D";
            this.rb3D.UseVisualStyleBackColor = true;
            this.rb3D.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(12, 9);
            this.rbNone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(69, 22);
            this.rbNone.TabIndex = 1;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbShowDialog);
            this.panel2.Controls.Add(this.rbShow);
            this.panel2.Location = new System.Drawing.Point(130, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 33);
            this.panel2.TabIndex = 3;
            // 
            // rbShowDialog
            // 
            this.rbShowDialog.AutoSize = true;
            this.rbShowDialog.Location = new System.Drawing.Point(105, 6);
            this.rbShowDialog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbShowDialog.Name = "rbShowDialog";
            this.rbShowDialog.Size = new System.Drawing.Size(123, 22);
            this.rbShowDialog.TabIndex = 1;
            this.rbShowDialog.Text = "ShowDialog";
            this.rbShowDialog.UseVisualStyleBackColor = true;
            // 
            // rbShow
            // 
            this.rbShow.AutoSize = true;
            this.rbShow.Checked = true;
            this.rbShow.Location = new System.Drawing.Point(12, 6);
            this.rbShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbShow.Name = "rbShow";
            this.rbShow.Size = new System.Drawing.Size(69, 22);
            this.rbShow.TabIndex = 1;
            this.rbShow.TabStop = true;
            this.rbShow.Text = "Show";
            this.rbShow.UseVisualStyleBackColor = true;
            this.rbShow.CheckedChanged += new System.EventHandler(this.rbShow_CheckedChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Enabled = false;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(201, 202);
            this.cmbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(246, 26);
            this.cmbColor.Sorted = true;
            this.cmbColor.TabIndex = 2;
            // 
            // cmbSingleStyle
            // 
            this.cmbSingleStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSingleStyle.Enabled = false;
            this.cmbSingleStyle.FormattingEnabled = true;
            this.cmbSingleStyle.Location = new System.Drawing.Point(201, 158);
            this.cmbSingleStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSingleStyle.Name = "cmbSingleStyle";
            this.cmbSingleStyle.Size = new System.Drawing.Size(246, 26);
            this.cmbSingleStyle.Sorted = true;
            this.cmbSingleStyle.TabIndex = 2;
            // 
            // cmb3DStyle
            // 
            this.cmb3DStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb3DStyle.FormattingEnabled = true;
            this.cmb3DStyle.Location = new System.Drawing.Point(201, 114);
            this.cmb3DStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb3DStyle.Name = "cmb3DStyle";
            this.cmb3DStyle.Size = new System.Drawing.Size(246, 26);
            this.cmb3DStyle.Sorted = true;
            this.cmb3DStyle.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "BorderColor：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "BorderSingleStyle：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Border3DStyle：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "BorderType：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "弹出行为：";
            // 
            // txbPopupFromTextBox
            // 
            this.txbPopupFromTextBox.Location = new System.Drawing.Point(172, 22);
            this.txbPopupFromTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPopupFromTextBox.Name = "txbPopupFromTextBox";
            this.txbPopupFromTextBox.Size = new System.Drawing.Size(172, 28);
            this.txbPopupFromTextBox.TabIndex = 1;
            this.txbPopupFromTextBox.Text = "从控件弹出";
            this.txbPopupFromTextBox.Click += new System.EventHandler(this.txbPopupFromTextBox_Click);
            this.txbPopupFromTextBox.TextChanged += new System.EventHandler(this.txbPopupFromTextBox_TextChanged);
            // 
            // btnPopupFromButton
            // 
            this.btnPopupFromButton.Location = new System.Drawing.Point(18, 20);
            this.btnPopupFromButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPopupFromButton.Name = "btnPopupFromButton";
            this.btnPopupFromButton.Size = new System.Drawing.Size(146, 34);
            this.btnPopupFromButton.TabIndex = 0;
            this.btnPopupFromButton.Text = "从控件弹出";
            this.btnPopupFromButton.UseVisualStyleBackColor = true;
            this.btnPopupFromButton.Click += new System.EventHandler(this.btnPopupFromButton_Click);
            // 
            // FmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 831);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FmMDI";
            this.Text = "PopupFormTester";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton btnNewChild;
        private System.Windows.Forms.ToolStripButton btnPopupFromItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel helpToolStripButton;
        private System.Windows.Forms.ToolStripButton btnNewNormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rb3D;
        private System.Windows.Forms.RadioButton rbShowDialog;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPopupFromTextBox;
        private System.Windows.Forms.Button btnPopupFromButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSingleStyle;
        private System.Windows.Forms.ComboBox cmb3DStyle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private ColorPicker colorPicker1;
        private System.Windows.Forms.Label label7;
    }
}



