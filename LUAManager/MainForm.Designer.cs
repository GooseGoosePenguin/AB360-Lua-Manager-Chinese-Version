
namespace LUAManager
{
    partial class MainForm
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
            EncryptButton = new System.Windows.Forms.Button();
            DecryptButton = new System.Windows.Forms.Button();
            DecodeButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            encryptInputLabel = new System.Windows.Forms.Label();
            encryptOutputLabel = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            encryptInputFile = new System.Windows.Forms.Label();
            encryptPanel = new System.Windows.Forms.Panel();
            customKeyEnc = new System.Windows.Forms.TextBox();
            encryptBrotipLabel = new System.Windows.Forms.Label();
            encryptGameSelect = new System.Windows.Forms.ComboBox();
            encryptOutputFile = new System.Windows.Forms.Label();
            SevenZipCheck = new System.Windows.Forms.RadioButton();
            LZMACheck = new System.Windows.Forms.RadioButton();
            RawFileCheck = new System.Windows.Forms.RadioButton();
            LetsGo = new System.Windows.Forms.Button();
            letsGoText = new System.Windows.Forms.Label();
            decryptPanel = new System.Windows.Forms.Panel();
            autoUnlzma = new System.Windows.Forms.CheckBox();
            customKeyDec = new System.Windows.Forms.TextBox();
            decryptInputFileButton = new System.Windows.Forms.Button();
            decryptBrotipLabel = new System.Windows.Forms.Label();
            autoUnzip = new System.Windows.Forms.CheckBox();
            decryptGameSelect = new System.Windows.Forms.ComboBox();
            decryptOutputFile = new System.Windows.Forms.Label();
            decryptInputLabel = new System.Windows.Forms.Label();
            decryptInputFile = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            decryptOutputLabel = new System.Windows.Forms.Label();
            decryptOutputFileButton = new System.Windows.Forms.Button();
            decodePanel = new System.Windows.Forms.Panel();
            button3 = new System.Windows.Forms.Button();
            decodeBrotipLabel = new System.Windows.Forms.Label();
            decodeOutputFile = new System.Windows.Forms.Label();
            decodeInputLabel = new System.Windows.Forms.Label();
            decodeInputFile = new System.Windows.Forms.Label();
            decodeOutputLabel = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            folderRadio = new System.Windows.Forms.RadioButton();
            fileRadio = new System.Windows.Forms.RadioButton();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            encryptPanel.SuspendLayout();
            decryptPanel.SuspendLayout();
            decodePanel.SuspendLayout();
            SuspendLayout();
            // 
            // EncryptButton
            // 
            EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            EncryptButton.ForeColor = System.Drawing.Color.White;
            EncryptButton.Location = new System.Drawing.Point(19, 19);
            EncryptButton.Margin = new System.Windows.Forms.Padding(5);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new System.Drawing.Size(118, 91);
            EncryptButton.TabIndex = 0;
            EncryptButton.Text = "加密";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // DecryptButton
            // 
            DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            DecryptButton.ForeColor = System.Drawing.Color.White;
            DecryptButton.Location = new System.Drawing.Point(278, 19);
            DecryptButton.Margin = new System.Windows.Forms.Padding(5);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new System.Drawing.Size(118, 91);
            DecryptButton.TabIndex = 1;
            DecryptButton.Text = "解密";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // DecodeButton
            // 
            DecodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            DecodeButton.ForeColor = System.Drawing.Color.White;
            DecodeButton.Location = new System.Drawing.Point(536, 19);
            DecodeButton.Margin = new System.Windows.Forms.Padding(5);
            DecodeButton.Name = "DecodeButton";
            DecodeButton.Size = new System.Drawing.Size(118, 91);
            DecodeButton.TabIndex = 2;
            DecodeButton.Text = "解码";
            DecodeButton.UseVisualStyleBackColor = true;
            DecodeButton.Click += DecodeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled;
            pictureBox1.Location = new System.Drawing.Point(566, 608);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(157, 125);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(2, 8);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 24);
            label1.TabIndex = 4;
            label1.Text = "Game:";
            // 
            // encryptInputLabel
            // 
            encryptInputLabel.AutoSize = true;
            encryptInputLabel.ForeColor = System.Drawing.Color.Transparent;
            encryptInputLabel.Location = new System.Drawing.Point(2, 69);
            encryptInputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            encryptInputLabel.Name = "encryptInputLabel";
            encryptInputLabel.Size = new System.Drawing.Size(165, 24);
            encryptInputLabel.TabIndex = 5;
            encryptInputLabel.Text = "Encrypt files from:";
            // 
            // encryptOutputLabel
            // 
            encryptOutputLabel.AutoSize = true;
            encryptOutputLabel.ForeColor = System.Drawing.Color.Transparent;
            encryptOutputLabel.Location = new System.Drawing.Point(2, 142);
            encryptOutputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            encryptOutputLabel.Name = "encryptOutputLabel";
            encryptOutputLabel.Size = new System.Drawing.Size(100, 24);
            encryptOutputLabel.TabIndex = 6;
            encryptOutputLabel.Text = "Output to:";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Green;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(113, 139);
            button1.Margin = new System.Windows.Forms.Padding(5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(118, 37);
            button1.TabIndex = 7;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Green;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(189, 66);
            button2.Margin = new System.Windows.Forms.Padding(5);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(118, 37);
            button2.TabIndex = 8;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // encryptInputFile
            // 
            encryptInputFile.ForeColor = System.Drawing.Color.White;
            encryptInputFile.Location = new System.Drawing.Point(5, 106);
            encryptInputFile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            encryptInputFile.Name = "encryptInputFile";
            encryptInputFile.Size = new System.Drawing.Size(625, 29);
            encryptInputFile.TabIndex = 9;
            encryptInputFile.Text = "InputFilePath";
            encryptInputFile.Visible = false;
            // 
            // encryptPanel
            // 
            encryptPanel.Controls.Add(customKeyEnc);
            encryptPanel.Controls.Add(button2);
            encryptPanel.Controls.Add(encryptBrotipLabel);
            encryptPanel.Controls.Add(encryptGameSelect);
            encryptPanel.Controls.Add(encryptOutputFile);
            encryptPanel.Controls.Add(encryptInputLabel);
            encryptPanel.Controls.Add(encryptInputFile);
            encryptPanel.Controls.Add(label1);
            encryptPanel.Controls.Add(encryptOutputLabel);
            encryptPanel.Controls.Add(button1);
            encryptPanel.Controls.Add(SevenZipCheck);
            encryptPanel.Controls.Add(LZMACheck);
            encryptPanel.Controls.Add(RawFileCheck);
            encryptPanel.Location = new System.Drawing.Point(19, 165);
            encryptPanel.Margin = new System.Windows.Forms.Padding(5);
            encryptPanel.Name = "encryptPanel";
            encryptPanel.Size = new System.Drawing.Size(635, 342);
            encryptPanel.TabIndex = 10;
            // 
            // customKeyEnc
            // 
            customKeyEnc.Location = new System.Drawing.Point(317, 0);
            customKeyEnc.Margin = new System.Windows.Forms.Padding(5);
            customKeyEnc.Name = "customKeyEnc";
            customKeyEnc.PlaceholderText = "Put a custom key here";
            customKeyEnc.Size = new System.Drawing.Size(310, 30);
            customKeyEnc.TabIndex = 29;
            customKeyEnc.Visible = false;
            // 
            // encryptBrotipLabel
            // 
            encryptBrotipLabel.AutoSize = true;
            encryptBrotipLabel.ForeColor = System.Drawing.Color.White;
            encryptBrotipLabel.Location = new System.Drawing.Point(0, 251);
            encryptBrotipLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            encryptBrotipLabel.Name = "encryptBrotipLabel";
            encryptBrotipLabel.Size = new System.Drawing.Size(658, 48);
            encryptBrotipLabel.TabIndex = 13;
            encryptBrotipLabel.Text = "Brotip: Newer versions of AB games always store LUAs in either 7z or LZMA \r\ncompression.";
            // 
            // encryptGameSelect
            // 
            encryptGameSelect.DisplayMember = "1";
            encryptGameSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            encryptGameSelect.FormattingEnabled = true;
            encryptGameSelect.Items.AddRange(new object[] { "Angry Birds Classic", "Angry Birds Seasons", "Angry Birds Rio", "Angry Birds Space", "Angry Birds Star Wars", "Angry Birds Star Wars II", "Angry Birds Friends", "Custom key" });
            encryptGameSelect.Location = new System.Drawing.Point(77, 2);
            encryptGameSelect.Margin = new System.Windows.Forms.Padding(5);
            encryptGameSelect.Name = "encryptGameSelect";
            encryptGameSelect.Size = new System.Drawing.Size(227, 32);
            encryptGameSelect.TabIndex = 11;
            encryptGameSelect.SelectedIndexChanged += IndexChangeEnc;
            // 
            // encryptOutputFile
            // 
            encryptOutputFile.ForeColor = System.Drawing.Color.White;
            encryptOutputFile.Location = new System.Drawing.Point(5, 181);
            encryptOutputFile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            encryptOutputFile.Name = "encryptOutputFile";
            encryptOutputFile.Size = new System.Drawing.Size(625, 70);
            encryptOutputFile.TabIndex = 10;
            encryptOutputFile.Text = "OutputFilePath";
            encryptOutputFile.Visible = false;
            // 
            // SevenZipCheck
            // 
            SevenZipCheck.AutoSize = true;
            SevenZipCheck.ForeColor = System.Drawing.Color.White;
            SevenZipCheck.Location = new System.Drawing.Point(3, 37);
            SevenZipCheck.Margin = new System.Windows.Forms.Padding(5);
            SevenZipCheck.Name = "SevenZipCheck";
            SevenZipCheck.Size = new System.Drawing.Size(200, 28);
            SevenZipCheck.TabIndex = 26;
            SevenZipCheck.Text = "Export in 7z format";
            SevenZipCheck.UseVisualStyleBackColor = true;
            // 
            // LZMACheck
            // 
            LZMACheck.AutoSize = true;
            LZMACheck.ForeColor = System.Drawing.Color.White;
            LZMACheck.Location = new System.Drawing.Point(206, 37);
            LZMACheck.Margin = new System.Windows.Forms.Padding(5);
            LZMACheck.Name = "LZMACheck";
            LZMACheck.Size = new System.Drawing.Size(231, 28);
            LZMACheck.TabIndex = 27;
            LZMACheck.Text = "Export in LZMA format";
            LZMACheck.UseVisualStyleBackColor = true;
            // 
            // RawFileCheck
            // 
            RawFileCheck.AutoSize = true;
            RawFileCheck.Checked = true;
            RawFileCheck.ForeColor = System.Drawing.Color.White;
            RawFileCheck.Location = new System.Drawing.Point(445, 37);
            RawFileCheck.Margin = new System.Windows.Forms.Padding(5);
            RawFileCheck.Name = "RawFileCheck";
            RawFileCheck.Size = new System.Drawing.Size(127, 28);
            RawFileCheck.TabIndex = 28;
            RawFileCheck.TabStop = true;
            RawFileCheck.Text = "Export raw";
            RawFileCheck.UseVisualStyleBackColor = true;
            // 
            // LetsGo
            // 
            LetsGo.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            LetsGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            LetsGo.ForeColor = System.Drawing.Color.White;
            LetsGo.Location = new System.Drawing.Point(262, 515);
            LetsGo.Margin = new System.Windows.Forms.Padding(5);
            LetsGo.Name = "LetsGo";
            LetsGo.Size = new System.Drawing.Size(149, 37);
            LetsGo.TabIndex = 11;
            LetsGo.Text = "开始摇滚吧！";
            LetsGo.UseVisualStyleBackColor = false;
            LetsGo.Click += LetsGo_Click;
            // 
            // letsGoText
            // 
            letsGoText.ForeColor = System.Drawing.Color.White;
            letsGoText.Location = new System.Drawing.Point(19, 566);
            letsGoText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            letsGoText.Name = "letsGoText";
            letsGoText.Size = new System.Drawing.Size(635, 37);
            letsGoText.TabIndex = 12;
            letsGoText.Text = "来次够!";
            letsGoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            letsGoText.Visible = false;
            // 
            // decryptPanel
            // 
            decryptPanel.Controls.Add(autoUnlzma);
            decryptPanel.Controls.Add(customKeyDec);
            decryptPanel.Controls.Add(decryptInputFileButton);
            decryptPanel.Controls.Add(decryptBrotipLabel);
            decryptPanel.Controls.Add(autoUnzip);
            decryptPanel.Controls.Add(decryptGameSelect);
            decryptPanel.Controls.Add(decryptOutputFile);
            decryptPanel.Controls.Add(decryptInputLabel);
            decryptPanel.Controls.Add(decryptInputFile);
            decryptPanel.Controls.Add(label9);
            decryptPanel.Controls.Add(decryptOutputLabel);
            decryptPanel.Controls.Add(decryptOutputFileButton);
            decryptPanel.Location = new System.Drawing.Point(19, 165);
            decryptPanel.Margin = new System.Windows.Forms.Padding(5);
            decryptPanel.Name = "decryptPanel";
            decryptPanel.Size = new System.Drawing.Size(635, 342);
            decryptPanel.TabIndex = 15;
            decryptPanel.Visible = false;
            // 
            // autoUnlzma
            // 
            autoUnlzma.AutoSize = true;
            autoUnlzma.BackColor = System.Drawing.Color.Transparent;
            autoUnlzma.Checked = true;
            autoUnlzma.CheckState = System.Windows.Forms.CheckState.Checked;
            autoUnlzma.ForeColor = System.Drawing.Color.White;
            autoUnlzma.Location = new System.Drawing.Point(322, 38);
            autoUnlzma.Margin = new System.Windows.Forms.Padding(5);
            autoUnlzma.Name = "autoUnlzma";
            autoUnlzma.Size = new System.Drawing.Size(205, 28);
            autoUnlzma.TabIndex = 21;
            autoUnlzma.Text = "自动解码 LZMA 格式";
            autoUnlzma.UseVisualStyleBackColor = false;
            // 
            // customKeyDec
            // 
            customKeyDec.Location = new System.Drawing.Point(317, 0);
            customKeyDec.Margin = new System.Windows.Forms.Padding(5);
            customKeyDec.Name = "customKeyDec";
            customKeyDec.PlaceholderText = "请输入密钥";
            customKeyDec.Size = new System.Drawing.Size(310, 30);
            customKeyDec.TabIndex = 20;
            customKeyDec.Visible = false;
            // 
            // decryptInputFileButton
            // 
            decryptInputFileButton.BackColor = System.Drawing.Color.Green;
            decryptInputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            decryptInputFileButton.ForeColor = System.Drawing.Color.White;
            decryptInputFileButton.Location = new System.Drawing.Point(189, 66);
            decryptInputFileButton.Margin = new System.Windows.Forms.Padding(5);
            decryptInputFileButton.Name = "decryptInputFileButton";
            decryptInputFileButton.Size = new System.Drawing.Size(118, 37);
            decryptInputFileButton.TabIndex = 8;
            decryptInputFileButton.Text = "浏览";
            decryptInputFileButton.UseVisualStyleBackColor = false;
            decryptInputFileButton.Click += button3_Click;
            // 
            // decryptBrotipLabel
            // 
            decryptBrotipLabel.ForeColor = System.Drawing.Color.White;
            decryptBrotipLabel.Location = new System.Drawing.Point(0, 251);
            decryptBrotipLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            decryptBrotipLabel.Name = "decryptBrotipLabel";
            decryptBrotipLabel.Size = new System.Drawing.Size(630, 91);
            decryptBrotipLabel.TabIndex = 13;
            decryptBrotipLabel.Text = "伙计给你个提示:有 2 个文件夹，一个文件夹包含要解密的文件，另一个文件夹用于发送文件。";
            // 
            // autoUnzip
            // 
            autoUnzip.AutoSize = true;
            autoUnzip.BackColor = System.Drawing.Color.Transparent;
            autoUnzip.Checked = true;
            autoUnzip.CheckState = System.Windows.Forms.CheckState.Checked;
            autoUnzip.ForeColor = System.Drawing.Color.White;
            autoUnzip.Location = new System.Drawing.Point(5, 38);
            autoUnzip.Margin = new System.Windows.Forms.Padding(5);
            autoUnzip.Name = "autoUnzip";
            autoUnzip.Size = new System.Drawing.Size(164, 28);
            autoUnzip.TabIndex = 12;
            autoUnzip.Text = "自动解密7z加密";
            autoUnzip.UseVisualStyleBackColor = false;
            // 
            // decryptGameSelect
            // 
            decryptGameSelect.DisplayMember = "1";
            decryptGameSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            decryptGameSelect.FormattingEnabled = true;
            decryptGameSelect.Items.AddRange(new object[] { "愤怒的小鸟经典版", "愤怒的小鸟季节版/嘉年华版", "愤怒的小鸟里约大冒险", "愤怒的小鸟太空版", "愤怒的小鸟星球大战", "愤怒的小鸟星球大战2", "愤怒的小鸟朋友版", "自定义密钥" });
            decryptGameSelect.Location = new System.Drawing.Point(77, 2);
            decryptGameSelect.Margin = new System.Windows.Forms.Padding(5);
            decryptGameSelect.Name = "decryptGameSelect";
            decryptGameSelect.Size = new System.Drawing.Size(227, 32);
            decryptGameSelect.TabIndex = 11;
            decryptGameSelect.SelectedIndexChanged += checkForFifthopt;
            // 
            // decryptOutputFile
            // 
            decryptOutputFile.ForeColor = System.Drawing.Color.White;
            decryptOutputFile.Location = new System.Drawing.Point(5, 181);
            decryptOutputFile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            decryptOutputFile.Name = "decryptOutputFile";
            decryptOutputFile.Size = new System.Drawing.Size(625, 70);
            decryptOutputFile.TabIndex = 10;
            decryptOutputFile.Text = "输出文件路径";
            decryptOutputFile.Visible = false;
            decryptOutputFile.Click += decryptOutputFile_Click;
            // 
            // decryptInputLabel
            // 
            decryptInputLabel.AutoSize = true;
            decryptInputLabel.ForeColor = System.Drawing.Color.Transparent;
            decryptInputLabel.Location = new System.Drawing.Point(2, 69);
            decryptInputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            decryptInputLabel.Name = "decryptInputLabel";
            decryptInputLabel.Size = new System.Drawing.Size(122, 24);
            decryptInputLabel.TabIndex = 5;
            decryptInputLabel.Text = "要解密的文件:";
            // 
            // decryptInputFile
            // 
            decryptInputFile.ForeColor = System.Drawing.Color.White;
            decryptInputFile.Location = new System.Drawing.Point(5, 106);
            decryptInputFile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            decryptInputFile.Name = "decryptInputFile";
            decryptInputFile.Size = new System.Drawing.Size(625, 29);
            decryptInputFile.TabIndex = 9;
            decryptInputFile.Text = "源文件路径";
            decryptInputFile.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.Transparent;
            label9.Location = new System.Drawing.Point(2, 8);
            label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(50, 24);
            label9.TabIndex = 4;
            label9.Text = "游戏:";
            label9.Click += label9_Click;
            // 
            // decryptOutputLabel
            // 
            decryptOutputLabel.AutoSize = true;
            decryptOutputLabel.ForeColor = System.Drawing.Color.Transparent;
            decryptOutputLabel.Location = new System.Drawing.Point(2, 142);
            decryptOutputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            decryptOutputLabel.Name = "decryptOutputLabel";
            decryptOutputLabel.Size = new System.Drawing.Size(68, 24);
            decryptOutputLabel.TabIndex = 6;
            decryptOutputLabel.Text = "输出到:";
            // 
            // decryptOutputFileButton
            // 
            decryptOutputFileButton.BackColor = System.Drawing.Color.Green;
            decryptOutputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            decryptOutputFileButton.ForeColor = System.Drawing.Color.White;
            decryptOutputFileButton.Location = new System.Drawing.Point(113, 139);
            decryptOutputFileButton.Margin = new System.Windows.Forms.Padding(5);
            decryptOutputFileButton.Name = "decryptOutputFileButton";
            decryptOutputFileButton.Size = new System.Drawing.Size(118, 37);
            decryptOutputFileButton.TabIndex = 7;
            decryptOutputFileButton.Text = "浏览";
            decryptOutputFileButton.UseVisualStyleBackColor = false;
            decryptOutputFileButton.Click += decryptOutputFileButton_Click;
            // 
            // decodePanel
            // 
            decodePanel.Controls.Add(button3);
            decodePanel.Controls.Add(decodeBrotipLabel);
            decodePanel.Controls.Add(decodeOutputFile);
            decodePanel.Controls.Add(decodeInputLabel);
            decodePanel.Controls.Add(decodeInputFile);
            decodePanel.Controls.Add(decodeOutputLabel);
            decodePanel.Controls.Add(button4);
            decodePanel.Location = new System.Drawing.Point(19, 165);
            decodePanel.Margin = new System.Windows.Forms.Padding(5);
            decodePanel.Name = "decodePanel";
            decodePanel.Size = new System.Drawing.Size(635, 342);
            decodePanel.TabIndex = 17;
            decodePanel.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Green;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(189, 6);
            button3.Margin = new System.Windows.Forms.Padding(5);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(118, 37);
            button3.TabIndex = 8;
            button3.Text = "Browse";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // decodeBrotipLabel
            // 
            decodeBrotipLabel.ForeColor = System.Drawing.Color.White;
            decodeBrotipLabel.Location = new System.Drawing.Point(0, 211);
            decodeBrotipLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            decodeBrotipLabel.Name = "decodeBrotipLabel";
            decodeBrotipLabel.Size = new System.Drawing.Size(630, 64);
            decodeBrotipLabel.TabIndex = 13;
            decodeBrotipLabel.Text = "Brotip: Make sure all LUA files in the folder are not encrypted before you continue\r\n";
            // 
            // decodeOutputFile
            // 
            decodeOutputFile.ForeColor = System.Drawing.Color.White;
            decodeOutputFile.Location = new System.Drawing.Point(5, 122);
            decodeOutputFile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            decodeOutputFile.Name = "decodeOutputFile";
            decodeOutputFile.Size = new System.Drawing.Size(625, 70);
            decodeOutputFile.TabIndex = 10;
            decodeOutputFile.Text = "OutputFilePath";
            decodeOutputFile.Visible = false;
            // 
            // decodeInputLabel
            // 
            decodeInputLabel.AutoSize = true;
            decodeInputLabel.ForeColor = System.Drawing.Color.Transparent;
            decodeInputLabel.Location = new System.Drawing.Point(2, 10);
            decodeInputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            decodeInputLabel.Name = "decodeInputLabel";
            decodeInputLabel.Size = new System.Drawing.Size(165, 24);
            decodeInputLabel.TabIndex = 5;
            decodeInputLabel.Text = "Decode files from:";
            // 
            // decodeInputFile
            // 
            decodeInputFile.ForeColor = System.Drawing.Color.White;
            decodeInputFile.Location = new System.Drawing.Point(5, 46);
            decodeInputFile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            decodeInputFile.Name = "decodeInputFile";
            decodeInputFile.Size = new System.Drawing.Size(625, 29);
            decodeInputFile.TabIndex = 9;
            decodeInputFile.Text = "InputFilePath";
            decodeInputFile.Visible = false;
            // 
            // decodeOutputLabel
            // 
            decodeOutputLabel.AutoSize = true;
            decodeOutputLabel.ForeColor = System.Drawing.Color.Transparent;
            decodeOutputLabel.Location = new System.Drawing.Point(2, 83);
            decodeOutputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            decodeOutputLabel.Name = "decodeOutputLabel";
            decodeOutputLabel.Size = new System.Drawing.Size(100, 24);
            decodeOutputLabel.TabIndex = 6;
            decodeOutputLabel.Text = "Output to:";
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Green;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button4.ForeColor = System.Drawing.Color.White;
            button4.Location = new System.Drawing.Point(113, 80);
            button4.Margin = new System.Windows.Forms.Padding(5);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(118, 37);
            button4.TabIndex = 7;
            button4.Text = "Browse";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // folderBrowserDialog2
            // 
            folderBrowserDialog2.HelpRequest += folderBrowserDialog2_HelpRequest;
            // 
            // folderRadio
            // 
            folderRadio.AutoSize = true;
            folderRadio.ForeColor = System.Drawing.Color.White;
            folderRadio.Location = new System.Drawing.Point(341, 120);
            folderRadio.Margin = new System.Windows.Forms.Padding(5);
            folderRadio.Name = "folderRadio";
            folderRadio.Size = new System.Drawing.Size(89, 28);
            folderRadio.TabIndex = 18;
            folderRadio.TabStop = true;
            folderRadio.Text = "文件夹";
            folderRadio.UseVisualStyleBackColor = true;
            folderRadio.CheckedChanged += folderRadio_CheckedChanged;
            // 
            // fileRadio
            // 
            fileRadio.AutoSize = true;
            fileRadio.ForeColor = System.Drawing.Color.White;
            fileRadio.Location = new System.Drawing.Point(264, 120);
            fileRadio.Margin = new System.Windows.Forms.Padding(5);
            fileRadio.Name = "fileRadio";
            fileRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            fileRadio.Size = new System.Drawing.Size(71, 28);
            fileRadio.TabIndex = 19;
            fileRadio.TabStop = true;
            fileRadio.Text = "文件";
            fileRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            fileRadio.UseVisualStyleBackColor = true;
            fileRadio.CheckedChanged += fileRadio_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(16, 615);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(516, 24);
            label2.TabIndex = 20;
            label2.Text = "汉化作者-航空企鹅 B站https://space.bilibili.com/631743456";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(19, 639);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(555, 24);
            label3.TabIndex = 21;
            label3.Text = "原版来自https://github.com/AB360-org/LUAManager/tree/v1.0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(50, 52, 54);
            ClientSize = new System.Drawing.Size(663, 694);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(fileRadio);
            Controls.Add(folderRadio);
            Controls.Add(letsGoText);
            Controls.Add(LetsGo);
            Controls.Add(pictureBox1);
            Controls.Add(DecodeButton);
            Controls.Add(DecryptButton);
            Controls.Add(EncryptButton);
            Controls.Add(decryptPanel);
            Controls.Add(encryptPanel);
            Controls.Add(decodePanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(5);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(685, 750);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(685, 750);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "加密解密怒鸟Lua文件-汉化来自航空企鹅";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            encryptPanel.ResumeLayout(false);
            encryptPanel.PerformLayout();
            decryptPanel.ResumeLayout(false);
            decryptPanel.PerformLayout();
            decodePanel.ResumeLayout(false);
            decodePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label encryptInputLabel;
        private System.Windows.Forms.Label encryptOutputLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label encryptInputFile;
        private System.Windows.Forms.Panel encryptPanel;
        private System.Windows.Forms.ComboBox encryptGameSelect;
        private System.Windows.Forms.Label encryptOutputFile;
        private System.Windows.Forms.Label encryptBrotipLabel;
        private System.Windows.Forms.Button LetsGo;
        private System.Windows.Forms.Label letsGoText;
        private System.Windows.Forms.Panel decryptPanel;
        private System.Windows.Forms.Button decryptInputFileButton;
        private System.Windows.Forms.Label decryptBrotipLabel;
        private System.Windows.Forms.CheckBox autoUnzip;
        private System.Windows.Forms.ComboBox decryptGameSelect;
        private System.Windows.Forms.Label decryptOutputFile;
        private System.Windows.Forms.Label decryptInputLabel;
        private System.Windows.Forms.Label decryptInputFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label decryptOutputLabel;
        private System.Windows.Forms.Button decryptOutputFileButton;
        private System.Windows.Forms.Panel decodePanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label decodeBrotipLabel;
        private System.Windows.Forms.Label decodeOutputFile;
        private System.Windows.Forms.Label decodeInputLabel;
        private System.Windows.Forms.Label decodeInputFile;
        private System.Windows.Forms.Label decodeOutputLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TextBox customKeyEnc;
        private System.Windows.Forms.RadioButton SevenZipCheck;
        private System.Windows.Forms.RadioButton LZMACheck;
        private System.Windows.Forms.RadioButton RawFileCheck;
        private System.Windows.Forms.CheckBox autoUnlzma;
        private System.Windows.Forms.TextBox customKeyDec;
        private System.Windows.Forms.RadioButton folderRadio;
        private System.Windows.Forms.RadioButton fileRadio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

