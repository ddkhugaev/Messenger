
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewChatList = new System.Windows.Forms.DataGridView();
            this.ColumnChats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewChat = new System.Windows.Forms.DataGridView();
            this.ColumnMyMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOtherMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxUserSearch = new System.Windows.Forms.ComboBox();
            this.labelStartChatMessage = new System.Windows.Forms.Label();
            this.textBoxNewMessage = new System.Windows.Forms.TextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
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
            this.dataGridViewChatList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChatList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChatList.ColumnHeadersVisible = false;
            this.dataGridViewChatList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnChats});
            this.dataGridViewChatList.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewChatList.MultiSelect = false;
            this.dataGridViewChatList.Name = "dataGridViewChatList";
            this.dataGridViewChatList.ReadOnly = true;
            this.dataGridViewChatList.RowHeadersVisible = false;
            this.dataGridViewChatList.RowHeadersWidth = 51;
            this.dataGridViewChatList.RowTemplate.Height = 50;
            this.dataGridViewChatList.Size = new System.Drawing.Size(400, 632);
            this.dataGridViewChatList.TabIndex = 0;
            this.dataGridViewChatList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChatList_CellClick);
            // 
            // ColumnChats
            // 
            this.ColumnChats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnChats.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.dataGridViewChat.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChat.ColumnHeadersVisible = false;
            this.dataGridViewChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMyMessages,
            this.ColumnOtherMessages});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChat.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewChat.Location = new System.Drawing.Point(424, 0);
            this.dataGridViewChat.MultiSelect = false;
            this.dataGridViewChat.Name = "dataGridViewChat";
            this.dataGridViewChat.ReadOnly = true;
            this.dataGridViewChat.RowHeadersVisible = false;
            this.dataGridViewChat.RowHeadersWidth = 51;
            this.dataGridViewChat.RowTemplate.Height = 150;
            this.dataGridViewChat.Size = new System.Drawing.Size(832, 632);
            this.dataGridViewChat.TabIndex = 1;
            // 
            // ColumnMyMessages
            // 
            this.ColumnMyMessages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnMyMessages.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnMyMessages.HeaderText = "ColumnMyMessages";
            this.ColumnMyMessages.MinimumWidth = 6;
            this.ColumnMyMessages.Name = "ColumnMyMessages";
            this.ColumnMyMessages.ReadOnly = true;
            this.ColumnMyMessages.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnOtherMessages
            // 
            this.ColumnOtherMessages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnOtherMessages.DefaultCellStyle = dataGridViewCellStyle7;
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
            this.comboBoxUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxUserSearch.FormattingEnabled = true;
            this.comboBoxUserSearch.Location = new System.Drawing.Point(0, 0);
            this.comboBoxUserSearch.Name = "comboBoxUserSearch";
            this.comboBoxUserSearch.Size = new System.Drawing.Size(400, 33);
            this.comboBoxUserSearch.TabIndex = 2;
            // 
            // labelStartChatMessage
            // 
            this.labelStartChatMessage.BackColor = System.Drawing.Color.White;
            this.labelStartChatMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartChatMessage.Location = new System.Drawing.Point(448, 24);
            this.labelStartChatMessage.Name = "labelStartChatMessage";
            this.labelStartChatMessage.Size = new System.Drawing.Size(784, 224);
            this.labelStartChatMessage.TabIndex = 3;
            this.labelStartChatMessage.Text = "Выберите чат";
            this.labelStartChatMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewMessage
            // 
            this.textBoxNewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewMessage.Location = new System.Drawing.Point(424, 640);
            this.textBoxNewMessage.Name = "textBoxNewMessage";
            this.textBoxNewMessage.Size = new System.Drawing.Size(696, 30);
            this.textBoxNewMessage.TabIndex = 4;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendMessage.Location = new System.Drawing.Point(1120, 640);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(136, 31);
            this.buttonSendMessage.TabIndex = 5;
            this.buttonSendMessage.Text = "Отправить";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // FormMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 673);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.textBoxNewMessage);
            this.Controls.Add(this.labelStartChatMessage);
            this.Controls.Add(this.comboBoxUserSearch);
            this.Controls.Add(this.dataGridViewChat);
            this.Controls.Add(this.dataGridViewChatList);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMyMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOtherMessages;
        private System.Windows.Forms.ComboBox comboBoxUserSearch;
        private System.Windows.Forms.Label labelStartChatMessage;
        private System.Windows.Forms.TextBox textBoxNewMessage;
        private System.Windows.Forms.Button buttonSendMessage;
    }
}