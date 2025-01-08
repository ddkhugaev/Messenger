
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewChatList = new System.Windows.Forms.DataGridView();
            this.dataGridViewChat = new System.Windows.Forms.DataGridView();
            this.ColumnChats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMyMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOtherMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewChatList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewChatList.MultiSelect = false;
            this.dataGridViewChatList.Name = "dataGridViewChatList";
            this.dataGridViewChatList.ReadOnly = true;
            this.dataGridViewChatList.RowHeadersVisible = false;
            this.dataGridViewChatList.RowHeadersWidth = 51;
            this.dataGridViewChatList.RowTemplate.Height = 50;
            this.dataGridViewChatList.Size = new System.Drawing.Size(400, 672);
            this.dataGridViewChatList.TabIndex = 0;
            // 
            // dataGridViewChat
            // 
            this.dataGridViewChat.AllowUserToAddRows = false;
            this.dataGridViewChat.AllowUserToDeleteRows = false;
            this.dataGridViewChat.AllowUserToResizeColumns = false;
            this.dataGridViewChat.AllowUserToResizeRows = false;
            this.dataGridViewChat.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChat.ColumnHeadersVisible = false;
            this.dataGridViewChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMyMessages,
            this.ColumnOtherMessages});
            this.dataGridViewChat.Location = new System.Drawing.Point(424, 0);
            this.dataGridViewChat.MultiSelect = false;
            this.dataGridViewChat.Name = "dataGridViewChat";
            this.dataGridViewChat.ReadOnly = true;
            this.dataGridViewChat.RowHeadersVisible = false;
            this.dataGridViewChat.RowHeadersWidth = 51;
            this.dataGridViewChat.RowTemplate.Height = 50;
            this.dataGridViewChat.Size = new System.Drawing.Size(832, 672);
            this.dataGridViewChat.TabIndex = 1;
            // 
            // ColumnChats
            // 
            this.ColumnChats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnChats.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnChats.HeaderText = "Column";
            this.ColumnChats.MinimumWidth = 6;
            this.ColumnChats.Name = "ColumnChats";
            this.ColumnChats.ReadOnly = true;
            this.ColumnChats.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnMyMessages
            // 
            this.ColumnMyMessages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnMyMessages.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnMyMessages.HeaderText = "ColumnMyMessages";
            this.ColumnMyMessages.MinimumWidth = 6;
            this.ColumnMyMessages.Name = "ColumnMyMessages";
            this.ColumnMyMessages.ReadOnly = true;
            this.ColumnMyMessages.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnMyMessages.Width = 6;
            // 
            // ColumnOtherMessages
            // 
            this.ColumnOtherMessages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnOtherMessages.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnOtherMessages.HeaderText = "ColumnOtherMessages";
            this.ColumnOtherMessages.MinimumWidth = 6;
            this.ColumnOtherMessages.Name = "ColumnOtherMessages";
            this.ColumnOtherMessages.ReadOnly = true;
            this.ColumnOtherMessages.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnOtherMessages.Width = 6;
            // 
            // FormMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dataGridViewChat);
            this.Controls.Add(this.dataGridViewChatList);
            this.Name = "FormMessenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мессенджер";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChatList;
        private System.Windows.Forms.DataGridView dataGridViewChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMyMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOtherMessages;
    }
}