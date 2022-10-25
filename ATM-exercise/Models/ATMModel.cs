using System.ComponentModel.DataAnnotations;


namespace ATM_exercise.Models
{
    public class ATMModel
    {
        [Key]
        public int Id { get; set; }
        public bool IsCardInserted { get; set; }
        public bool IsOperatorMode { get; set; }
        public decimal ATMmachineBalance { get; set; }
        public decimal WithdrawalFeeAmount { get; set; }
        public DateTime WithdrawalDate { get; set; }
    }
}
