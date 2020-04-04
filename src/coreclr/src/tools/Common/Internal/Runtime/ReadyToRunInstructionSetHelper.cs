
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// DO NOT EDIT THIS FILE! IT IS AUTOGENERATED
// FROM /src/coreclr/src/tools/Common/JitInterface/ThunkGenerator/InstructionSetDesc.txt
// using /src/coreclr/src/tools/Common/JitInterface/ThunkGenerator/gen.bat

using System;
using System.Runtime.InteropServices;
using Internal.JitInterface;
using Internal.TypeSystem;

namespace Internal.ReadyToRunConstants
{
    public static class ReadyToRunInstructionSetHelper
    {
        public static ReadyToRunInstructionSet? R2RInstructionSet(this InstructionSet instructionSet, TargetArchitecture architecture)
        {
            switch (architecture)
            {

                case TargetArchitecture.ARM64:
                    {
                        switch (instructionSet)
                        {
                            case InstructionSet.ARM64_ArmBase: return ReadyToRunInstructionSet.ArmBase;
                            case InstructionSet.ARM64_ArmBase_Arm64: return ReadyToRunInstructionSet.ArmBase;
                            case InstructionSet.ARM64_AdvSimd: return ReadyToRunInstructionSet.AdvSimd;
                            case InstructionSet.ARM64_AdvSimd_Arm64: return ReadyToRunInstructionSet.AdvSimd;
                            case InstructionSet.ARM64_Aes: return ReadyToRunInstructionSet.Aes;
                            case InstructionSet.ARM64_Crc32: return ReadyToRunInstructionSet.Crc32;
                            case InstructionSet.ARM64_Crc32_Arm64: return ReadyToRunInstructionSet.Crc32;
                            case InstructionSet.ARM64_Sha1: return ReadyToRunInstructionSet.Sha1;
                            case InstructionSet.ARM64_Sha256: return ReadyToRunInstructionSet.Sha256;
                            case InstructionSet.ARM64_Atomics: return ReadyToRunInstructionSet.Atomics;
                            case InstructionSet.ARM64_Vector64: return null;
                            case InstructionSet.ARM64_Vector128: return null;

                            default: throw new Exception("Unknown instruction set");
                        }
                    }

                case TargetArchitecture.X64:
                    {
                        switch (instructionSet)
                        {
                            case InstructionSet.X64_SSE: return ReadyToRunInstructionSet.Sse;
                            case InstructionSet.X64_SSE_X64: return ReadyToRunInstructionSet.Sse;
                            case InstructionSet.X64_SSE2: return ReadyToRunInstructionSet.Sse2;
                            case InstructionSet.X64_SSE2_X64: return ReadyToRunInstructionSet.Sse2;
                            case InstructionSet.X64_SSE3: return ReadyToRunInstructionSet.Sse3;
                            case InstructionSet.X64_SSSE3: return ReadyToRunInstructionSet.Ssse3;
                            case InstructionSet.X64_SSE41: return ReadyToRunInstructionSet.Sse41;
                            case InstructionSet.X64_SSE41_X64: return ReadyToRunInstructionSet.Sse41;
                            case InstructionSet.X64_SSE42: return ReadyToRunInstructionSet.Sse42;
                            case InstructionSet.X64_SSE42_X64: return ReadyToRunInstructionSet.Sse42;
                            case InstructionSet.X64_AVX: return ReadyToRunInstructionSet.Avx;
                            case InstructionSet.X64_AVX2: return ReadyToRunInstructionSet.Avx2;
                            case InstructionSet.X64_AES: return ReadyToRunInstructionSet.Aes;
                            case InstructionSet.X64_BMI1: return ReadyToRunInstructionSet.Bmi1;
                            case InstructionSet.X64_BMI1_X64: return ReadyToRunInstructionSet.Bmi1;
                            case InstructionSet.X64_BMI2: return ReadyToRunInstructionSet.Bmi2;
                            case InstructionSet.X64_BMI2_X64: return ReadyToRunInstructionSet.Bmi2;
                            case InstructionSet.X64_FMA: return ReadyToRunInstructionSet.Fma;
                            case InstructionSet.X64_LZCNT: return ReadyToRunInstructionSet.Lzcnt;
                            case InstructionSet.X64_LZCNT_X64: return ReadyToRunInstructionSet.Lzcnt;
                            case InstructionSet.X64_PCLMULQDQ: return ReadyToRunInstructionSet.Pclmulqdq;
                            case InstructionSet.X64_POPCNT: return ReadyToRunInstructionSet.Popcnt;
                            case InstructionSet.X64_POPCNT_X64: return ReadyToRunInstructionSet.Popcnt;
                            case InstructionSet.X64_Vector128: return null;
                            case InstructionSet.X64_Vector256: return null;

                            default: throw new Exception("Unknown instruction set");
                        }
                    }

                case TargetArchitecture.X86:
                    {
                        switch (instructionSet)
                        {
                            case InstructionSet.X86_SSE: return ReadyToRunInstructionSet.Sse;
                            case InstructionSet.X86_SSE2: return ReadyToRunInstructionSet.Sse2;
                            case InstructionSet.X86_SSE3: return ReadyToRunInstructionSet.Sse3;
                            case InstructionSet.X86_SSSE3: return ReadyToRunInstructionSet.Ssse3;
                            case InstructionSet.X86_SSE41: return ReadyToRunInstructionSet.Sse41;
                            case InstructionSet.X86_SSE42: return ReadyToRunInstructionSet.Sse42;
                            case InstructionSet.X86_AVX: return ReadyToRunInstructionSet.Avx;
                            case InstructionSet.X86_AVX2: return ReadyToRunInstructionSet.Avx2;
                            case InstructionSet.X86_AES: return ReadyToRunInstructionSet.Aes;
                            case InstructionSet.X86_BMI1: return ReadyToRunInstructionSet.Bmi1;
                            case InstructionSet.X86_BMI2: return ReadyToRunInstructionSet.Bmi2;
                            case InstructionSet.X86_FMA: return ReadyToRunInstructionSet.Fma;
                            case InstructionSet.X86_LZCNT: return ReadyToRunInstructionSet.Lzcnt;
                            case InstructionSet.X86_PCLMULQDQ: return ReadyToRunInstructionSet.Pclmulqdq;
                            case InstructionSet.X86_POPCNT: return ReadyToRunInstructionSet.Popcnt;
                            case InstructionSet.X86_Vector128: return null;
                            case InstructionSet.X86_Vector256: return null;

                            default: throw new Exception("Unknown instruction set");
                        }
                    }

                default: throw new Exception("Unknown architecture");
            }
        }
    }
}