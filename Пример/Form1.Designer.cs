
namespace Пример
{
    partial class Example
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFolder = new System.Windows.Forms.Button();
            this.PathToFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RecordedFile = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WriteTextFile = new System.Windows.Forms.Button();
            this.ReadTextFile = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.TextBox();
            this.PathToFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectFile = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(288, 6);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(89, 20);
            this.SelectFolder.TabIndex = 0;
            this.SelectFolder.Text = "Select Folder";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.FolderSelect_Click);
            // 
            // PathToFolder
            // 
            this.PathToFolder.Location = new System.Drawing.Point(48, 6);
            this.PathToFolder.Name = "PathToFolder";
            this.PathToFolder.Size = new System.Drawing.Size(234, 20);
            this.PathToFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь:";
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tabPage1);
            this.Menu.Controls.Add(this.tabPage2);
            this.Menu.Location = new System.Drawing.Point(3, 3);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(401, 291);
            this.Menu.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.WriteTextFile);
            this.tabPage1.Controls.Add(this.FileName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.RecordedFile);
            this.tabPage1.Controls.Add(this.PathToFolder);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SelectFolder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(393, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Запись";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RecordedFile
            // 
            this.RecordedFile.Location = new System.Drawing.Point(11, 58);
            this.RecordedFile.Multiline = true;
            this.RecordedFile.Name = "RecordedFile";
            this.RecordedFile.Size = new System.Drawing.Size(366, 163);
            this.RecordedFile.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ReadTextFile);
            this.tabPage2.Controls.Add(this.PathToFile);
            this.tabPage2.Controls.Add(this.SelectFile);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.OpenFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(393, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Чтение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(135, 32);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(234, 20);
            this.FileName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наименование файла:";
            // 
            // WriteTextFile
            // 
            this.WriteTextFile.Location = new System.Drawing.Point(11, 226);
            this.WriteTextFile.Name = "WriteTextFile";
            this.WriteTextFile.Size = new System.Drawing.Size(366, 33);
            this.WriteTextFile.TabIndex = 6;
            this.WriteTextFile.Text = "Accomplish";
            this.WriteTextFile.UseVisualStyleBackColor = true;
            this.WriteTextFile.Click += new System.EventHandler(this.WriteTextFile_Click);
            // 
            // ReadTextFile
            // 
            this.ReadTextFile.Location = new System.Drawing.Point(14, 226);
            this.ReadTextFile.Name = "ReadTextFile";
            this.ReadTextFile.Size = new System.Drawing.Size(366, 33);
            this.ReadTextFile.TabIndex = 13;
            this.ReadTextFile.Text = "Accomplish";
            this.ReadTextFile.UseVisualStyleBackColor = true;
            this.ReadTextFile.Click += new System.EventHandler(this.ReadTextFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(14, 32);
            this.OpenFile.Multiline = true;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(366, 189);
            this.OpenFile.TabIndex = 10;
            // 
            // PathToFile
            // 
            this.PathToFile.Location = new System.Drawing.Point(51, 6);
            this.PathToFile.Name = "PathToFile";
            this.PathToFile.Size = new System.Drawing.Size(234, 20);
            this.PathToFile.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Путь:";
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(291, 6);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(89, 20);
            this.SelectFile.TabIndex = 7;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.FileSelect_Click);
            // 
            // Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 295);
            this.Controls.Add(this.Menu);
            this.Name = "Example";
            this.Text = "Example";
            this.Menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.TextBox PathToFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox RecordedFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button WriteTextFile;
        private System.Windows.Forms.Button ReadTextFile;
        private System.Windows.Forms.TextBox PathToFile;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OpenFile;
    }
}

