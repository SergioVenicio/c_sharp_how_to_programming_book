namespace _10_9_Employee.Models
{
    class PieceWorker: Employee
    {
        public decimal WagePerPiece { get; private set; }
        public int Quantity { get; private set; }

        public PieceWorker(
            string firstName, string lastName,
            decimal wagePerPieceValue, int quantityValue
        ): base(firstName, lastName)
        {
            WagePerPiece = wagePerPieceValue;
            Quantity = quantityValue;
        }

        public override decimal Earnings()
        {
            return Quantity * WagePerPiece;
        }

        public override string ToString()
        {
            return $"PieceWorker: {base.ToString()}";
        }
    }
}
