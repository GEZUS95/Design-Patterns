namespace assignment2
{
    public interface IATMState
    {
        void InsertCard();
        void EnterPin(int pin);
        void WithdrawCash(int amount);
        void RejectCard();
    }
}
