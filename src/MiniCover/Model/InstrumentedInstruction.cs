﻿namespace MiniCover.Model
{
    public class InstrumentedInstruction
    {
        public int Id { get; set; }
        public int StartLine { get; set; }
        public int EndLine { get; set; }
        public int StartColumn { get; set; }
        public int EndColumn { get; set; }
        public string Instruction { get; set; }
    }
}
