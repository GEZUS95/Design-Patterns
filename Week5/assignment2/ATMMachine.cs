namespace assignment2
{
    public class ATMMachine
    {
        private int _amountInMachine;
        private IATMState _cardPresent;
        private IATMState _correctPinCode;
        private IATMState _noCard;
        private IATMState _noCash;
        private IATMState _machineState;

        public int AmmountInMachine { get { return _amountInMachine; } set {_amountInMachine = value; } }

        public ATMMachine(int amountinmachine)
        {
            AmmountInMachine = amountinmachine;
            _cardPresent = new CardPresentState(this);
            _correctPinCode = new CorrectPinState(this);
            _noCard = new NoCardState(this);
            _noCash = new NoCashState(this);

            _machineState = _noCard;
        }

        public void EnterPincode(int pincode)
        {
            _machineState.EnterPin(pincode);
        }

        public IATMState GetCardPresentState()
        {
            return _cardPresent;
        }

        public IATMState GetCorrectPinState()
        {
            return _correctPinCode;
        }

        public IATMState GetNoCardState()
        {
            return _noCard;
        }

        public IATMState GetNoCashState()
        {
            return _noCash;
        }

        public void InsertCard()
        {
            _machineState.InsertCard();
        }
        public void RejectCard()
        {
            _machineState.RejectCard();
        }

        public void SetAmountInMachine(int amount)
        {
            AmmountInMachine = amount;
        }

        public void SetMachineState(IATMState state)
        {
            _machineState = state;
        }

        public void WithdrawCash(int amount)
        {
            _machineState.WithdrawCash(amount);
        }
    }
}