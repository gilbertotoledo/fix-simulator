﻿using FixSimulatorDesktop.State;

namespace FixSimulatorDesktop.View
{
    public partial class NewOrderSingleForm : Form
    {
        private readonly Action _sendOrder;

        public NewOrderSingleForm(Action sendOrder)
        {
            _sendOrder = sendOrder;
            InitializeComponent();

            SymbolTxt.Text = StateManager.Symbol;
            AccountTxt.Text = StateManager.Account;
            QuantityTxt.Text = StateManager.Quantity.ToString();
            PriceTxt.Text = StateManager.Price.ToString();
            SideBuyRb.Checked = StateManager.Side == '1';
            SideSellRb.Checked = StateManager.Side == '2';
            OperationCb.SelectedIndex = StateManager.Operation == "POSITION" ? 0 : 1;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            _sendOrder.Invoke();
            this.Close();
        }

        private void SymbolTxt_TextChanged(object sender, EventArgs e)
        {
            StateManager.Symbol = SymbolTxt.Text;
        }

        private void QuantityTxt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(QuantityTxt.Text, out var quantity))
            {
                StateManager.Quantity = quantity;
            }
            else
            {
                QuantityTxt.Text = StateManager.Quantity.ToString();
            }
        }

        private void PriceTxt_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(PriceTxt.Text, out var price))
            {
                StateManager.Price = price;
            }
            else
            {
                PriceTxt.Text = StateManager.Price.ToString();
            }
        }

        private void AccountTxt_TextChanged(object sender, EventArgs e)
        {
            StateManager.Account = AccountTxt.Text;
        }

        private void OperationCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            StateManager.Operation = OperationCb.SelectedItem as string;
        }

        private void SideBuyRb_CheckedChanged(object sender, EventArgs e)
        {
            StateManager.Side = '1';
        }

        private void SideSellRb_CheckedChanged(object sender, EventArgs e)
        {
            StateManager.Side = '2';
        }
    }
}
