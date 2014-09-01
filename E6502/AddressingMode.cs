using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6502
{
    public enum AddressingMode
    {
        Absolute,
        AbsoluteX,
        AbsoluteY,

        /// <summary>
        /// Some instructions like LSR and ROR can operate directly on the
        /// accumulator.
        /// </summary>
        Accumulator,

        /// <summary>
        /// The instruction contains an 1byte constant address.
        /// </summary>
        Immediate,

        /// <summary>
        /// The source and destination of the address is implied directly by the
        /// function itself. such as CLC and RTS
        /// </summary>
        Implied,
        IndirectX,
        IndirectY,
        Indirect,
        Relative,

        /// <summary>
        /// An instruction using zero page addressing has only an 8bit address operand.
        /// This limits it to addressing only the first 256 bytes of memory (0x0000 -> 0x00FF)
        /// where the most significant bytes of the address is always zero.
        /// 
        /// In zero page mode only the LSB of the address is held in the instruction.
        /// </summary>
        ZeroPage,

        /// <summary>
        /// The address to be accessed by an instruction using indexed zero page address (ZPA) uses
        /// the 8bit ZPA from the instruction and adding the current value of the X register to it.
        /// </summary>
        ZeroPageX,
        ZeroPageY
    }
}
