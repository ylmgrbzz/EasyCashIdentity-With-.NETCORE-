﻿namespace EasyCashEntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessId { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; }
    }
}