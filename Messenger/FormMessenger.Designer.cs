
namespace Messenger
{
    partial class FormMessenger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessenger));
            this.dataGridViewChatList = new System.Windows.Forms.DataGridView();
            this.ColumnChats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewChat = new System.Windows.Forms.DataGridView();
            this.ColumnMyMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOtherMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxUserSearch = new System.Windows.Forms.ComboBox();
            this.labelStartChatMessage = new System.Windows.Forms.Label();
            this.textBoxNewMessage = new System.Windows.Forms.TextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.labelSendMessageForNewChat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChatList
            // 
            this.dataGridViewChatList.AllowUserToAddRows = false;
            this.dataGridViewChatList.AllowUserToDeleteRows = false;
            this.dataGridViewChatList.AllowUserToResizeColumns = false;
            this.dataGridViewChatList.AllowUserToResizeRows = false;
            this.dataGridViewChatList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.dataGridViewChatList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChatList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChatList.ColumnHeadersVisible = false;
            this.dataGridViewChatList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnChats});
            this.dataGridViewChatList.Location = new System.Drawing.Point(8, 56);
            this.dataGridViewChatList.MultiSelect = false;
            this.dataGridViewChatList.Name = "dataGridViewChatList";
            this.dataGridViewChatList.ReadOnly = true;
            this.dataGridViewChatList.RowHeadersVisible = false;
            this.dataGridViewChatList.RowHeadersWidth = 51;
            this.dataGridViewChatList.RowTemplate.Height = 50;
            this.dataGridViewChatList.Size = new System.Drawing.Size(392, 608);
            this.dataGridViewChatList.TabIndex = 0;
            this.dataGridViewChatList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChatList_CellClick);
            // 
            // ColumnChats
            // 
            this.ColumnChats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnChats.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnChats.HeaderText = "Column";
            this.ColumnChats.MinimumWidth = 6;
            this.ColumnChats.Name = "ColumnChats";
            this.ColumnChats.ReadOnly = true;
            this.ColumnChats.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewChat
            // 
            this.dataGridViewChat.AllowUserToAddRows = false;
            this.dataGridViewChat.AllowUserToDeleteRows = false;
            this.dataGridViewChat.AllowUserToResizeColumns = false;
            this.dataGridViewChat.AllowUserToResizeRows = false;
            this.dataGridViewChat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewChat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.dataGridViewChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChat.ColumnHeadersVisible = false;
            this.dataGridViewChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMyMessages,
            this.ColumnOtherMessages});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChat.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewChat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.dataGridViewChat.Location = new System.Drawing.Point(424, 8);
            this.dataGridViewChat.MultiSelect = false;
            this.dataGridViewChat.Name = "dataGridViewChat";
            this.dataGridViewChat.ReadOnly = true;
            this.dataGridViewChat.RowHeadersVisible = false;
            this.dataGridViewChat.RowHeadersWidth = 51;
            this.dataGridViewChat.RowTemplate.Height = 150;
            this.dataGridViewChat.Size = new System.Drawing.Size(824, 616);
            this.dataGridViewChat.TabIndex = 1;
            // 
            // ColumnMyMessages
            // 
            this.ColumnMyMessages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnMyMessages.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnMyMessages.HeaderText = "ColumnMyMessages";
            this.ColumnMyMessages.MinimumWidth = 6;
            this.ColumnMyMessages.Name = "ColumnMyMessages";
            this.ColumnMyMessages.ReadOnly = true;
            this.ColumnMyMessages.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnOtherMessages
            // 
            this.ColumnOtherMessages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnOtherMessages.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnOtherMessages.HeaderText = "ColumnOtherMessages";
            this.ColumnOtherMessages.MinimumWidth = 6;
            this.ColumnOtherMessages.Name = "ColumnOtherMessages";
            this.ColumnOtherMessages.ReadOnly = true;
            this.ColumnOtherMessages.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // comboBoxUserSearch
            // 
            this.comboBoxUserSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUserSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUserSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.comboBoxUserSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxUserSearch.ForeColor = System.Drawing.Color.White;
            this.comboBoxUserSearch.FormattingEnabled = true;
            this.comboBoxUserSearch.Location = new System.Drawing.Point(8, 8);
            this.comboBoxUserSearch.Name = "comboBoxUserSearch";
            this.comboBoxUserSearch.Size = new System.Drawing.Size(392, 33);
            this.comboBoxUserSearch.TabIndex = 2;
            this.comboBoxUserSearch.SelectedValueChanged += new System.EventHandler(this.comboBoxUserSearch_SelectedValueChanged);
            // 
            // labelStartChatMessage
            // 
            this.labelStartChatMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.labelStartChatMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartChatMessage.ForeColor = System.Drawing.Color.White;
            this.labelStartChatMessage.Location = new System.Drawing.Point(448, 24);
            this.labelStartChatMessage.Name = "labelStartChatMessage";
            this.labelStartChatMessage.Size = new System.Drawing.Size(784, 224);
            this.labelStartChatMessage.TabIndex = 3;
            this.labelStartChatMessage.Text = "Выберите чат";
            this.labelStartChatMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewMessage
            // 
            this.textBoxNewMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.textBoxNewMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewMessage.ForeColor = System.Drawing.Color.White;
            this.textBoxNewMessage.Location = new System.Drawing.Point(424, 632);
            this.textBoxNewMessage.Name = "textBoxNewMessage";
            this.textBoxNewMessage.Size = new System.Drawing.Size(784, 30);
            this.textBoxNewMessage.TabIndex = 4;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.buttonSendMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSendMessage.BackgroundImage")));
            this.buttonSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendMessage.ForeColor = System.Drawing.Color.White;
            this.buttonSendMessage.Location = new System.Drawing.Point(1216, 631);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(32, 33);
            this.buttonSendMessage.TabIndex = 5;
            this.buttonSendMessage.UseVisualStyleBackColor = false;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // labelSendMessageForNewChat
            // 
            this.labelSendMessageForNewChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.labelSendMessageForNewChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSendMessageForNewChat.ForeColor = System.Drawing.Color.White;
            this.labelSendMessageForNewChat.Location = new System.Drawing.Point(448, 272);
            this.labelSendMessageForNewChat.Name = "labelSendMessageForNewChat";
            this.labelSendMessageForNewChat.Size = new System.Drawing.Size(784, 224);
            this.labelSendMessageForNewChat.TabIndex = 6;
            this.labelSendMessageForNewChat.Text = "Отправьте сообщение, чтобы начать новый чат";
            this.labelSendMessageForNewChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1257, 673);
            this.Controls.Add(this.labelSendMessageForNewChat);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.textBoxNewMessage);
            this.Controls.Add(this.labelStartChatMessage);
            this.Controls.Add(this.comboBoxUserSearch);
            this.Controls.Add(this.dataGridViewChat);
            this.Controls.Add(this.dataGridViewChatList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMessenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мессенджер";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChatList;
        private System.Windows.Forms.DataGridView dataGridViewChat;
        private System.Windows.Forms.ComboBox comboBoxUserSearch;
        private System.Windows.Forms.Label labelStartChatMessage;
        private System.Windows.Forms.TextBox textBoxNewMessage;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.Label labelSendMessageForNewChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMyMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOtherMessages;
    }
}