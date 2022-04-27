﻿///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Team4_Project4/Team4_Project4
//	File Name:         ProgramController.cs
//	Description:       ProgramController class for controlling majority of program functionality
//	Course:            CSCI-4717-201 - Comp Architecture
//	Authors:           Zachary Lykins, lykinsz@etsu.edu            
//	                   Bobby Mullins, mullinsbd@etsu.edu
//	                   Christopher Poteet, poteetc1@etsu.edu
//	                   William Simmons, simmonswa@etsu.edu
//                     Isaiah Jayne, jaynei@etsu.edu
//	Created:           Monday, February  14, 2022
//	Copyright:         Team 4
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Team4_Project4
{
    /// <summary>
    ///  ProgramController class for controlling majority of program functionality
    /// </summary>
    public class ProgramController
    {
        public static GUIForm guiForm;    //GUIForm instance to open program to
        public static int LRULRU, LRU = 0;
        //General Function Methods
        #region startProgram() Method
        /// <summary>
        /// Method for starting program
        /// </summary>
        public static void startProgram()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Opens application to guiForm
            guiForm = new GUIForm();
            Application.Run(guiForm);

        }//end startProgram()
        #endregion

        #region exitProgram() Method
        /// <summary>
        /// Method for exiting program
        /// </summary>
        public static void exitProgram()
        {
            Environment.Exit(0);

        }//end exitProgram()
        #endregion

        #region openFile() Method
        /// <summary>
        /// Method for inputting an entire text file into one string
        /// </summary>
        /// <returns>Input string from entire text file</returns>
        public static string openFile()
        {
            OpenFileDialog fd = new OpenFileDialog();
            StreamReader reader;

            string Path;
            string FileContent = "";

            //fd.InitialDirectory = "c:\\";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                Path = fd.FileName;

                var FileStream = fd.OpenFile();

                reader = new StreamReader(FileStream);

                FileContent = reader.ReadToEnd();

                return FileContent;
            }

            return FileContent;

        }//end openFile()
        #endregion

        #region saveFile() Method
        /// <summary>
        /// Method for outputting a text file from a string
        /// </summary>
        /// <param name="outputString">String to be output to a text file</param>
        public static void saveFile(string outputString)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.ShowDialog();

            if (sf.FileName != "")
            {
                File.WriteAllText(sf.FileName, outputString);
            }

        }//end saveFile()
        #endregion

        #region openInformation() Method
        /// <summary>
        /// Method for opening instruction set information
        /// </summary>
        public static void openInformation()
        {
            //Get the current directory
            string filePath = Directory.GetCurrentDirectory();

            //Move up two parent directories
            filePath = Directory.GetParent(filePath).FullName;
            filePath = Directory.GetParent(filePath).FullName;

            filePath += "\\Files\\Information.txt";

            //Open the file located at filePath (which is Information.txt)
            Process.Start(filePath);

        }//end openInformation()
        #endregion


        //Assemble & Disassemble Methods
        #region assemble() Method
        /// <summary>
        /// Master Method for assembling custom assembly language instruction set into machine code
        /// </summary>        
        /// <param name="assemblyString">Input assembly code to assemble</param>
        /// <returns>Final assemble output (Machine Code)</returns>
        public static string assemble(string assemblyString)
        {
            string assembleOutput = "";

            string disassembledText = assemblyString;


            disassembledText = Regex.Replace(disassembledText, @"\d{4}[\t]*\s+", "");
            disassembledText = Regex.Replace(disassembledText, @"\s+", "");
            int numConverts = disassembledText.Count(f => f == '#');


            int wFlag = 0;
            int counter = 0;
            while (wFlag == 0)
            {
                Int32 macInstruct = 0;
                string instruction = string.Empty;
                instruction += disassembledText[counter];
                counter++;
                instruction += disassembledText[counter];
                counter++;
                instruction += disassembledText[counter];
                counter++;
                instruction += disassembledText[counter];
                counter++;
                switch (instruction)
                {
                    case string n when (n == "LDRE"):

                        counter += 3;
                        if (disassembledText[counter] == 'R')
                        {
                            macInstruct += 0;
                        }
                        else if (disassembledText[counter] == '#')
                        {
                            macInstruct += 8;
                        }
                        else
                        {
                            macInstruct += 16;
                        }

                        counter -= 3;
                        break;
                    case string n when (n == "STRE"):
                        macInstruct += 24;
                        break;
                    case string n when (n == "MOVE"):
                        macInstruct += 32;
                        break;
                    case string n when (n == "COMP"):
                        macInstruct += 40;
                        break;
                    case string n when (n == "ANDD"):
                        macInstruct += 48;
                        break;
                    case string n when (n == "OORR"):
                        macInstruct += 56;
                        break;
                    case string n when (n == "BRLT"):
                        macInstruct += 64;
                        break;
                    case string n when (n == "BRGT"):
                        macInstruct += 72;
                        break;
                    case string n when (n == "BREQ"):
                        macInstruct += 80;
                        break;
                    case string n when (n == "BRAN"):
                        macInstruct += 88;
                        break;
                    case string n when (n == "ADDI"):
                        macInstruct += 96;
                        break;
                    case string n when (n == "SUBT"):
                        macInstruct += 104;
                        break;
                    case string n when (n == "STOP"):
                        macInstruct += 255;
                        string hexValue = macInstruct.ToString("X2");
                        hexValue = hexValue.Insert(2, " ");
                        assembleOutput += hexValue;
                        wFlag = 1;
                        break;
                    default:
                        wFlag = 1;
                        MessageBox.Show("There was an invalid Mnemonic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }

                if (wFlag == 0)
                {
                    string register = "";
                    register += disassembledText[counter];
                    counter++;
                    register += disassembledText[counter];
                    counter++;
                    switch (register)
                    {
                        case string n when (n == "R0"):
                            macInstruct += 0;
                            break;
                        case string n when (n == "R1"):
                            macInstruct += 1;
                            break;
                        case string n when (n == "R2"):
                            macInstruct += 2;
                            break;
                        case string n when (n == "R3"):
                            macInstruct += 3;
                            break;
                        case string n when (n == "R4"):
                            macInstruct += 4;
                            break;
                        case string n when (n == "R5"):
                            macInstruct += 5;
                            break;
                        case string n when (n == "R6"):
                            macInstruct += 6;
                            break;
                        case string n when (n == "R7"):
                            macInstruct += 7;
                            break;

                    }
                    counter++;
                    string hexValue = macInstruct.ToString("X2");
                    hexValue = hexValue.Insert(2, " ");
                    assembleOutput += hexValue;
                    Int32 dataInstruct = 0;
                    string addressingMode = "";
                    addressingMode = Convert.ToString(disassembledText[counter]);
                    switch (addressingMode)
                    {
                        case string n when (n == "R"):
                            counter += 2;
                            if (disassembledText[counter] == 'R')
                            {
                                counter--;
                                counter--;
                                dataInstruct += 3;
                                switch (disassembledText[counter])
                                {
                                    case char i when (i == '0'):
                                        dataInstruct += 0;
                                        break;
                                    case char i when (i == '1'):
                                        dataInstruct += 2097152;
                                        break;
                                    case char i when (i == '2'):
                                        dataInstruct += 4194304;
                                        break;
                                    case char i when (i == '3'):
                                        dataInstruct += 6291456;
                                        break;
                                    case char i when (i == '4'):
                                        dataInstruct += 8388608;
                                        break;
                                    case char i when (i == '5'):
                                        dataInstruct += 10485760;
                                        break;
                                    case char i when (i == '6'):
                                        dataInstruct += 12582912;
                                        break;
                                    case char i when (i == '7'):
                                        dataInstruct += 14680064;
                                        break;

                                }
                                counter++;
                                counter++;
                                counter++;
                                switch (disassembledText[counter])
                                {
                                    case char i when (i == '0'):
                                        dataInstruct += 0;
                                        break;
                                    case char i when (i == '1'):
                                        dataInstruct += 262144;
                                        break;
                                    case char i when (i == '2'):
                                        dataInstruct += 524288;
                                        break;
                                    case char i when (i == '3'):
                                        dataInstruct += 786432;
                                        break;
                                    case char i when (i == '4'):
                                        dataInstruct += 1048576;
                                        break;
                                    case char i when (i == '5'):
                                        dataInstruct += 1310720;
                                        break;
                                    case char i when (i == '6'):
                                        dataInstruct += 1572864;
                                        break;
                                    case char i when (i == '7'):
                                        dataInstruct += 1835008;
                                        break;

                                }
                                counter--;
                            }
                            else
                            {
                                counter--;
                                dataInstruct += 0;
                                switch (disassembledText[counter])
                                {
                                    case char i when (i == '0'):
                                        dataInstruct += 0;
                                        break;
                                    case char i when (i == '1'):
                                        dataInstruct += 2097152;
                                        break;
                                    case char i when (i == '2'):
                                        dataInstruct += 4194304;
                                        break;
                                    case char i when (i == '3'):
                                        dataInstruct += 6291456;
                                        break;
                                    case char i when (i == '4'):
                                        dataInstruct += 8388608;
                                        break;
                                    case char i when (i == '5'):
                                        dataInstruct += 10485760;
                                        break;
                                    case char i when (i == '6'):
                                        dataInstruct += 12582912;
                                        break;
                                    case char i when (i == '7'):
                                        dataInstruct += 14680064;
                                        break;

                                }
                                counter++;

                            }
                            counter -= 2;
                            break;
                        case string n when (n == "#"):
                            dataInstruct += 1;
                            counter++;
                            string immediate = "";
                            int counter2 = 0;
                            while (Char.IsNumber(disassembledText, counter) == true)
                            {
                                immediate += disassembledText[counter];
                                counter++;
                                counter2++;
                            }
                            dataInstruct += Int32.Parse(immediate);
                            counter -= counter2;
                            counter--;
                            break;
                        case string n when (n == "&"):
                            dataInstruct += 2;
                            counter++;
                            string memory = "";
                            counter2 = 0;
                            while (Char.IsNumber(disassembledText, counter) == true)
                            {
                                memory += disassembledText[counter];
                                counter++;
                                counter2++;
                            }
                            dataInstruct += Int32.Parse(memory);
                            counter -= counter2;
                            counter--;
                            break;
                    }
                    hexValue = dataInstruct.ToString("X6");

                    hexValue = hexValue.Insert(2, " ");
                    hexValue = hexValue.Insert(5, " ");
                    hexValue = hexValue.Insert(8, " ");
                    assembleOutput += hexValue;
                }

                counter += 2;
            }

            return assembleOutput;
        }//end assemble()
        #endregion

        #region disassemble() Method
        /// <summary>
        /// Master Method for disassembling machine code into assembly
        /// </summary>
        /// <param name="machineString">Input machine code</param>
        /// <returns>Disassembled assembly code</returns>
        public static string disassemble(string machineString)
        {
            string disassembleOutput = "";

            Int32[] opTokens = new Int32[2];
            string[] machineCode = machineString.Split(' ');

            int wFlag = 0;
            int counter = 0;
            while (wFlag == 0)
            {
                string opcode = machineCode[counter];
                counter++;

                opTokens = ProgramController.disassembleTokens(opcode);
                string counterOutput = counter.ToString("D4");

                switch (opTokens[0])
                {
                    case Int32 n when (n == 0):     //  LDRE    R,R
                        disassembleOutput += counterOutput + "\tLDRE";
                        break;
                    case Int32 n when (n == 8):     //  LDRE    R, Immediate
                        disassembleOutput += counterOutput + "\tLDRE";
                        break;
                    case Int32 n when (n == 16):    //  LDRE    R, Memory
                        disassembleOutput += counterOutput + "\tLDRE";
                        break;
                    case Int32 n when (n == 24):    //  STRE    &R, R
                        disassembleOutput += counterOutput + "\tSTRE";
                        break;
                    case Int32 n when (n == 32):    //  MOVE    R, R
                        disassembleOutput += counterOutput + "\tMOVE";
                        break;
                    case Int32 n when (n == 40):    //  COMP    R, R, R
                        disassembleOutput += counterOutput + "\tCOMP";
                        break;
                    case Int32 n when (n == 48):    //  ANDD    R, R, R
                        disassembleOutput += counterOutput + "\tANDD";
                        break;
                    case Int32 n when (n == 56):    //  OORR    R, R
                        disassembleOutput += counterOutput + "\tOORR";
                        break;
                    case Int32 n when (n == 64):    //  BRLT    R, R
                        disassembleOutput += counterOutput + "\tBRLT";
                        break;
                    case Int32 n when (n == 72):    //  BRGT    R, R
                        disassembleOutput += counterOutput + "\tBRGT";
                        break;
                    case Int32 n when (n == 80):    //  BREQ    R, R
                        disassembleOutput += counterOutput + "\tBREQ";
                        break;
                    case Int32 n when (n == 88):    //  BRAN    R, R
                        disassembleOutput += counterOutput + "\tBRAN";
                        break;
                    case Int32 n when (n == 96):    //  ADDI    R, R, R
                        disassembleOutput += counterOutput + "\tADDI";
                        break;
                    case Int32 n when (n == 104):   //  SUBT    R, R, R
                        disassembleOutput += counterOutput + "\tSUBT";
                        break;
                    case Int32 n when (n == 248):   //  STOP 
                        disassembleOutput += counterOutput + "\tSTOP";
                        wFlag = 1;
                        break;
                    default:                        // Nothing matches invalid instruction
                        wFlag = 1;
                        disassembleOutput += counterOutput + "\tERROR: INVALID INSTRUCTION";
                        MessageBox.Show("There was an invalid machine code instruction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                if (wFlag == 0)
                {
                    switch (opTokens[1])
                    {
                        case Int32 n when (n == 0):     // R0
                            disassembleOutput += "   R0";
                            break;
                        case Int32 n when (n == 1):     // R1
                            disassembleOutput += "   R1";
                            break;
                        case Int32 n when (n == 2):     // R2
                            disassembleOutput += "   R2";
                            break;
                        case Int32 n when (n == 3):     // R3
                            disassembleOutput += "   R3";
                            break;
                        case Int32 n when (n == 4):     // R4
                            disassembleOutput += "   R4";
                            break;
                        case Int32 n when (n == 5):     // R5
                            disassembleOutput += "   R5";
                            break;
                        case Int32 n when (n == 6):     // R6
                            disassembleOutput += "   R6";
                            break;
                        case Int32 n when (n == 7):     // R7
                            disassembleOutput += "   R7";
                            break;
                    }

                    Int32[] dataTokens = new Int32[3];
                    string data = string.Empty;

                    data = machineCode[counter];
                    counter++;
                    data += machineCode[counter];
                    counter++;
                    data += machineCode[counter];
                    counter++;

                    dataTokens = ProgramController.disassembleData(data);
                    switch (dataTokens[0])
                    {
                        case Int32 n when (n == 0):
                            disassembleOutput += $", R{dataTokens[1] >> 21} \r\n";
                            break;
                        case Int32 n when (n == 1):
                            disassembleOutput += $", #{dataTokens[1] >> 6}\r\n";
                            break;
                        case Int32 n when (n == 2):
                            disassembleOutput += $", &{dataTokens[1] >> 2}\r\n";
                            break;
                        case Int32 n when (n == 3):
                            disassembleOutput += $", R{dataTokens[1] >> 21}";
                            disassembleOutput += $", R{dataTokens[2] >> 18} \r\n";
                            break;
                    }
                }
            }

            return disassembleOutput;
        }//end disassemble()
        #endregion

        #region disassembleTokens() Method
        /// <summary>
        /// Master Method for disassembling opcode into assembly
        /// </summary>
        /// <param name="opcodeString">Input machine code opcode</param>
        /// <returns>Opcode disassemble output</returns>
        public static Int32[] disassembleTokens(string opcodeString)
        {
            Int32[] tokens = new Int32[2];

            Int32 inp = Convert.ToInt32(opcodeString, 16);
            tokens[0] = (inp & 248);                            // AND with binary (11111000) to keep all 1 and get 5 bytes of opcode
            tokens[1] = (inp & 7);                              // AND  with binary (00000111) to keep all 1 and get 3 bytes for registers

            return tokens;

        }//end disassembleTokens()
        #endregion

        #region dissassembleData() Method
        /// <summary>
        /// Method for calculating tokens based on instruction parameters/registers
        /// </summary>
        /// <param name="machineString">Input machine code line after instruction to convert to tokens</param>
        /// <returns>Int32 token array from instruction parameters/registers</returns>
        public static Int32[] disassembleData(string machineString)
        {
            Int32[] tokens = new Int32[3];
            Int32 data = Convert.ToInt32(machineString, 16);
            tokens[0] = (data & 3);
            switch (tokens[0])
            {
                case Int32 n when (n == 0):
                    tokens[1] = (data & 14680064);
                    break;
                case Int32 n when (n == 1):
                    tokens[1] = (data & 16777152);
                    break;
                case Int32 n when (n == 2):
                    tokens[1] = (data & 16777212);
                    break;
                case Int32 n when (n == 3):
                    tokens[1] = (data & 14680064);
                    tokens[2] = (data & 1835008);
                    break;

            }
            return tokens;
        }
        #endregion


        //Static Pipeline Phase Methods
        #region fetch() Method
        /// <summary>
        /// Method for fetching instruction phase in pipeline
        /// </summary>
        /// <param name="fetchInput">Input instruction to fetch</param>
        /// <returns>@$$</returns>
        public static (List<Instruction>, int, int, int) fetch(List<string> instructions, List<Instruction> pipeInts, int progCount, int i)
        {
            string instLit = string.Empty;
            int stopF = 0;
            int stringLoc = 0;

            switch (instructions[i])
            {
                case string n when (n == "LDRE"):
                    char loadType = checkAddressing(instructions[i + 2]);
                    if (loadType == 'R')
                    {
                        instLit += instructions[i];
                        instLit += " ";
                        instLit += instructions[i + 1];
                        instLit += " ";
                        instLit += instructions[i + 2];

                        Instruction LDRERR = new Instruction(progCount += 4, 1, 1, 1, 2, instructions[i + 1], instructions[i + 2], instLit);
                        pipeInts.Add(LDRERR);
                        i += 4;

                    }
                    else if (loadType == '#')
                    {
                        instLit += instructions[i];
                        instLit += " ";
                        instLit += instructions[i + 1];
                        instLit += " ";
                        instLit += instructions[i + 2];

                        Instruction LDRERI = new Instruction(progCount += 4, 1, 1, 1, 2, instructions[i + 1], string.Empty, instLit);
                        pipeInts.Add(LDRERI);
                        i += 4;
                    }
                    else
                    {
                        instLit += instructions[i];
                        instLit += " ";
                        instLit += instructions[i + 1];
                        instLit += " ";
                        instLit += instructions[i + 2];


                        Instruction LDRERM = new Instruction(progCount += 4, 1, 1, 3, 2, instructions[i + 1], instructions[i + 2], instLit);
                        pipeInts.Add(LDRERM);
                        i += 4;
                    }
                    break;

                case string n when (n == "STRE"):
                    instLit += instructions[i];
                    instLit += " ";
                    instLit += instructions[i + 1];
                    instLit += " ";
                    instLit += instructions[i + 2];


                    Instruction STRE = new Instruction(progCount += 4, 1, 1, 3, 2, instructions[i + 1], instructions[i + 2], instLit);
                    pipeInts.Add(STRE);
                    i += 4;
                    break;

                case string n when (n == "COMP"):
                    instLit += instructions[i];
                    instLit += " ";
                    instLit += instructions[i + 1];
                    instLit += " ";
                    instLit += instructions[i + 2];
                    instLit += " ";
                    instLit += instructions[i + 3];

                    Instruction COMP = new Instruction(progCount += 4, 1, 1, 1, 2, instructions[i + 1], instructions[i + 2], instructions[i + 3], instLit);
                    pipeInts.Add(COMP);
                    i += 5;
                    break;

                case string n when (n == "ANDD"):
                    instLit += instructions[i];
                    instLit += " ";
                    instLit += instructions[i + 1];
                    instLit += " ";
                    instLit += instructions[i + 2];
                    instLit += " ";
                    instLit += instructions[i + 3];

                    Instruction ANDD = new Instruction(progCount += 4, 1, 1, 1, 2, instructions[i + 1], instructions[i + 2], instructions[i + 3], instLit);
                    pipeInts.Add(ANDD);
                    i += 5;
                    break;

                case string n when (n == "OORR"):
                    instLit += instructions[i];
                    instLit += " ";
                    instLit += instructions[i + 1];
                    instLit += " ";
                    instLit += instructions[i + 2];
                    instLit += " ";
                    instLit += instructions[i + 3];

                    Instruction OORR = new Instruction(progCount += 4, 1, 1, 1, 2, instructions[i + 1], instructions[i + 2], instructions[i + 3], instLit);
                    pipeInts.Add(OORR);
                    i += 5;
                    break;

                case string n when (n == "BRLT"):
                    //checks zero flag to take branch
                    if (guiForm.getReg("R0") == 1)
                    {
                        //gets branch instruction
                        instLit += instructions[i];
                        instLit += instructions[i + 1];

                        stringLoc = instructions.IndexOf(instructions[i + 1] + ":");    //looks for jump point

                        if (stringLoc == -1)
                        {
                            //error
                            MessageBox.Show("Invalid Branch",
                                            "There was no branch found with that name.",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                        else
                        {
                            //creates brlt instruction and adds to pipeline
                            Instruction BRLT = new Instruction(progCount += 4, 1, 1, 1, 1, instructions[i + 1], instLit);
                            pipeInts.Add(BRLT);
                            i = stringLoc + 2;          //set jump point as next instruction
                        }
                        //grabs next instruction after branch location label then removes branch from pipeline
                        (pipeInts, progCount, i, stopF) = ProgramController.fetch(instructions, pipeInts, progCount, i);
                        pipeInts.RemoveAt(0);
                    }
                    //does not take branch and gets next instruction
                    else
                    {
                        i += 3;
                        (pipeInts, progCount, i, stopF) = ProgramController.fetch(instructions, pipeInts, progCount, i);
                    }
                    break;

                case string n when (n == "BRGT"):
                    //if zero flag set
                    if (guiForm.getReg("R0") == 1)
                    {
                        //gets branch instruction
                        instLit += instructions[i];
                        instLit += instructions[i + 1];

                        stringLoc = instructions.IndexOf(instructions[i + 1] + ":");    //looks for jump point

                        if (stringLoc == -1)
                        {
                            //error
                            MessageBox.Show("Invalid Branch",
                                            "There was no branch found with that name.",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                        else
                        {
                            //creates brgt instruction
                            Instruction BRGT = new Instruction(progCount += 4, 1, 1, 1, 1, instructions[i + 1], instLit);
                            pipeInts.Add(BRGT);
                            i = stringLoc + 2;          //set jump point as next instruction
                        }

                        //gets next instruction and removes brgt
                        (pipeInts, progCount, i, stopF) = ProgramController.fetch(instructions, pipeInts, progCount, i);
                        pipeInts.RemoveAt(0);
                    }
                    //skips branch and goes to next instruction
                    else
                    {
                        i += 3;
                        (pipeInts, progCount, i, stopF) = ProgramController.fetch(instructions, pipeInts, progCount, i);
                    }
                    break;

                case string n when (n == "BREQ"):
                    //enter if zero flag is set 
                    if (guiForm.getReg("R0") == 1)
                    {
                        //gets branch instruction and locaiton to branch to
                        instLit += instructions[i];
                        instLit += instructions[i + 1];

                        stringLoc = instructions.IndexOf(instructions[i + 1] + ":");    //looks for jump point

                        if (stringLoc == -1)
                        {
                            //error
                            MessageBox.Show("Invalid Branch",
                                            "There was no branch found with that name.",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                        else
                        {
                            //creates nreq instructino
                            Instruction BREQ = new Instruction(progCount += 4, 1, 1, 1, 1, instructions[i + 1], instLit);
                            pipeInts.Add(BREQ);
                            i = stringLoc + 2;          //set jump point as next instruction
                        }

                        //grabs next instruction then removes breq instruction
                        (pipeInts, progCount, i, stopF) = ProgramController.fetch(instructions, pipeInts, progCount, i);
                        pipeInts.RemoveAt(0);
                    }
                    //skips branch and grabs next instruction
                    else
                    {
                        i += 3;
                        (pipeInts, progCount, i, stopF) = ProgramController.fetch(instructions, pipeInts, progCount, i);
                    }

                    break;

                case string n when (n == "BRAN"):
                    //gets branch instruction and location to branch to
                    instLit += instructions[i];
                    instLit += instructions[i + 1];

                    stringLoc = instructions.IndexOf(instructions[i + 1] + ":");    //looks for jump point

                    //error if branch point
                    if (stringLoc == -1)
                    {
                        //error
                        MessageBox.Show("Invalid Branch",
                                        "There was no branch found with that name.",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }

                    else
                    {
                        //creates bran instruction
                        Instruction BRAN = new Instruction(progCount += 4, 1, 1, 1, 1, instructions[i + 1], instLit);
                        pipeInts.Add(BRAN);
                        i = stringLoc + 2;          //set jump point as next instruction
                    }

                    //gets next intsruction after branch
                    (pipeInts, progCount, i, stopF) = ProgramController.fetch(instructions, pipeInts, progCount, i);
                    //removes bran instruction from pipeline
                    pipeInts.RemoveAt(0);

                    break;

                case string n when (n == "ADDI"):
                    instLit += instructions[i];
                    instLit += " ";
                    instLit += instructions[i + 1];
                    instLit += " ";
                    instLit += instructions[i + 2];


                    Instruction ADDI = new Instruction(progCount += 4, 1, 1, 1, 2, instructions[i + 1], instructions[i + 2], instructions[i + 3], instLit);
                    pipeInts.Add(ADDI);
                    i += 5;
                    break;

                case string n when (n == "SUBT"):
                    instLit += instructions[i];
                    instLit += " ";
                    instLit += instructions[i + 1];
                    instLit += " ";
                    instLit += instructions[i + 2];


                    Instruction SUBT = new Instruction(progCount += 4, 1, 1, 1, 2, instructions[i + 1], instructions[i + 2], instructions[i + 3], instLit);
                    pipeInts.Add(SUBT);
                    i += 5;
                    break;

                case string n when (n == "FADD"):
                    instLit += instructions[i];
                    instLit += " ";
                    instLit += instructions[i + 1];
                    instLit += " ";
                    instLit += instructions[i + 2];
                    instLit += " ";
                    instLit += instructions[i + 3];

                    Instruction FADD = new Instruction(progCount += 4, 1, 1, 2, 2, instructions[i + 1], instructions[i + 2], instructions[i + 3], instLit);
                    pipeInts.Add(FADD);
                    i += 5;
                    break;

                case string n when (n == "FSUB"):
                    instLit += instructions[i];
                    instLit += " ";
                    instLit += instructions[i + 1];
                    instLit += " ";
                    instLit += instructions[i + 2];
                    instLit += " ";
                    instLit += instructions[i + 3];

                    Instruction FSUB = new Instruction(progCount += 4, 1, 1, 2, 2, instructions[i + 1], instructions[i + 2], instructions[i + 3], instLit);
                    pipeInts.Add(FSUB);
                    i += 5;
                    break;


                case string n when (n == "FMUL"):
                    instLit += instructions[i];
                    instLit += " ";
                    instLit += instructions[i + 1];
                    instLit += " ";
                    instLit += instructions[i + 2];
                    instLit += " ";
                    instLit += instructions[i + 3];

                    Instruction FMUL = new Instruction(progCount += 4, 1, 1, 5, 2, instructions[i + 1], instructions[i + 2], instructions[i + 3], instLit);
                    pipeInts.Add(FMUL);
                    i += 5;
                    break;

                case string n when (n == "FDIV"):
                    instLit += instructions[i];
                    instLit += " ";
                    instLit += instructions[i + 1];
                    instLit += " ";
                    instLit += instructions[i + 2];
                    instLit += " ";
                    instLit += instructions[i + 3];

                    Instruction FDIV = new Instruction(progCount += 4, 1, 1, 10, 2, instructions[i + 1], instructions[i + 2], instructions[i + 3], instLit);
                    pipeInts.Add(FDIV);
                    i += 5;
                    break;

                case string n when (n == "NOOP"):
                    instLit += instructions[i];
                    instLit += " ";
                    instLit += instructions[i + 1];
                    instLit += " ";
                    instLit += instructions[i + 2];

                    Instruction NOOP = new Instruction(progCount += 4, 1, 1, 1, 1, instructions[i + 1], instructions[i + 2], instLit);
                    pipeInts.Add(NOOP);
                    i += 4;
                    break;

                case string n when (n == "STOP"):
                    instLit += instructions[i];
                    Instruction STOP = new Instruction(progCount += 4, 1, 1, 1, 1, String.Empty, String.Empty, instLit);
                    pipeInts.Add(STOP);
                    stopF = 1;
                    break;
            }

            return (pipeInts, progCount, i, stopF);

        }//end fetch()
        #endregion

        #region decode() Method
        /// <summary>
        /// Method for decoding instruction phase in pipeline
        /// </summary>
        /// <param name="decodeInput">Input instruction to decode</param>
        /// <returns></returns>
        public static (string, string, string) decode(Instruction pipeInts)
        {
            string param2 = string.Empty;
            if (pipeInts.P2Register != string.Empty)
            {
                param2 = pipeInts.P2Register;
            }

            return (pipeInts.SRegister, pipeInts.P1Register, pipeInts.P2Register);

        }//end decode()
        #endregion

        #region execute() Method
        /// <summary>
        /// Method for executing instruction phase in pipeline
        /// </summary>
        /// <param name="executeInput">Input instruction to execute</param>
        /// <returns></returns>
        public static bool execute(string executeInput)
        {
            bool ifStop = false;

            if (executeInput == "STOP")
            {
                ifStop = true;
            }

            return ifStop;

        }
        public static void execute(Instruction pipeInts)
        {
            // switch statement to call appropiate instruction method for instruction currently in pipe
            switch ($"{pipeInts.InstLit[0]}{pipeInts.InstLit[1]}{pipeInts.InstLit[2]}{pipeInts.InstLit[3]}")
            {
                case string n when (n == "LDRE"):
                    if (pipeInts.p1Register[0] == 'R')
                    {
                        LDRER(pipeInts);
                    }
                    else if (pipeInts.p1Register[0] == '#')
                    {
                        LDREI(pipeInts);
                    }
                    else
                    {
                        LDREM(pipeInts);
                    }
                    break;

                case string n when (n == "STRE"):
                    STRE(pipeInts);
                    break;

                case string n when (n == "COMP"):
                    COMP(pipeInts);
                    break;

                case string n when (n == "ANDD"):
                    ANDD(pipeInts);
                    break;

                case string n when (n == "OORR"):
                    OORR(pipeInts);
                    break;

                case string n when (n == "BRLT"):
                    //Dont need???
                    break;

                case string n when (n == "BRGT"):
                    //Dont need???
                    break;

                case string n when (n == "BREQ"):
                    //Dont need???
                    break;

                case string n when (n == "BRAN"):
                    //Dont need???
                    break;

                case string n when (n == "ADDI"):
                    ADDI(pipeInts);
                    break;

                case string n when (n == "SUBT"):
                    SUBT(pipeInts);
                    break;

                case string n when (n == "FADD"):
                    FADD(pipeInts);
                    break;

                case string n when (n == "FSUB"):
                    FSUB(pipeInts);
                    break;

                case string n when (n == "FMUL"):
                    FMUL(pipeInts);
                    break;

                case string n when (n == "FDIV"):
                    FDIV(pipeInts);
                    break;

                case string n when (n == "NOOP"):
                    //No method needed for NOOP
                    break;

                case string n when (n == "STOP"):
                    //No method needed for STOP
                    break;
            }

        }//end execute()
        #endregion

        #region store() Method
        /// <summary>
        /// Method for storing instruction phase in pipeline
        /// </summary>
        /// <param name="storeInput">Input instruction to store</param>
        /// <returns></returns>
        public static string store(string storeInput)
        {
            string storeOutput = "";

            //======================================//
            //INSERT CODE FOR STORING/FINISHING HERE//
            //======================================//

            return storeOutput;

        }//end store()
        #endregion

        #region checkAddressing() Method
        /// <summary>
        /// Method for figuring out addressing mode
        /// </summary>
        /// <param name="instruction">instruction to get addressing mode of</param>
        /// <returns></returns>
        public static Char checkAddressing(string instruction)
        {
            if (instruction[0] == 'R')
            {
                return 'r';
            }

            else if (instruction[0] == '#')
            {
                return 'i';
            }

            else
            {
                return 'm';
            }
        }
        #endregion


        //Pipeline Output Methods
        #region outputDynamicPipelineStats() Method
        /// <summary>
        /// Method for outputting dynamic pipeline simulation statistics
        /// </summary>
        /// <param name="structural">Structural hazards</param>
        /// <param name="data">Data hazards</param>
        /// <param name="control">Control hazards</param>
        /// <param name="RAW">read-after-write dependencies</param>
        /// <param name="WAR">write-after-read dependencies</param>
        /// <param name="WAW">write-after-write dependencies</param>
        /// <param name="buffer">Reorder Buffer delays</param>
        /// <param name="station">Reservation Station delays</param>
        /// <param name="conflict">Data Memory Conflict delays</param>
        /// <param name="dependence">True Dependence delays</param>
        /// <param name="cycles">Total cycles of dynamic pipeline simulation</param>
        /// <returns>Statistics of the pipeline from the dynamic pipeline simulation</returns>
        public static string outputDynamicPipelineStats(int structural,
                                                 int data,
                                                 int control,
                                                 int RAW,
                                                 int WAR,
                                                 int WAW,
                                                 int buffer,
                                                 int station,
                                                 int conflict,
                                                 int dependence,
                                                 int cycles)
        {
            return $"Hazards\r\n" +
                   $"=======\r\n" +
                   $"structural: {structural}\r\n" +
                   $"data: {data}\r\n" +
                   $"control: {control}\r\n" +
                   $"\r\n" +

                   $"Dependencies\r\n" +
                   $"============\r\n" +
                   $"read-after-write: {RAW}\r\n" +
                   $"write-after-read: {WAR}\r\n" +
                   $"write-after-write: {WAW}\r\n" +
                   $"\r\n" +

                   $"Delays\r\n" +
                   $"======\r\n" +
                   $"reorder buffer delays: {buffer}\r\n" +
                   $"reservation station delays: {station}\r\n" +
                   $"data memory conflict delays: {conflict}\r\n" +
                   $"true dependence delays: {dependence}\r\n" +
                   $"\r\n" +

                   $"Total Cycles\r\n" +
                   $"============\r\n" +
                   $"{cycles}\r\n";

        }//end outputDynamicPipelineStats()
        #endregion

        #region outputStaticPipelineStats() Method
        /// <summary>
        /// Method for outputting static pipeline simulation statistics
        /// </summary>
        /// <param name="structural">Structural hazards</param>
        /// <param name="data">Data hazards</param>
        /// <param name="control">Control hazards</param>
        /// <param name="RAW">read-after-write dependencies</param>
        /// <param name="WAR">write-after-read dependencies</param>
        /// <param name="WAW">write-after-write dependencies</param>
        /// <param name="fetch">Fetch cycles stalled</param>
        /// <param name="decode">Decode cycles stalled</param>
        /// <param name="execute">Execute cycles stalled</param>
        /// <param name="store">Store cycles stalled</param>
        /// <param name="cycles">Total cycles of static pipeline simulation</param>
        /// <returns>Statistics of the pipeline from the static pipeline simulation</returns>
        public static string outputStaticPipelineStats(int structural,
                                                 int data,
                                                 int control,
                                                 int RAW,
                                                 int WAR,
                                                 int WAW,
                                                 int fetch,
                                                 int decode,
                                                 int execute,
                                                 int store,
                                                 int cycles)
        {
            return $"Hazards\r\n" +
                   $"=======\r\n" +
                   $"structural: {structural}\r\n" +
                   $"data: {data}\r\n" +
                   $"control: {control}\r\n" +
                   $"\r\n" +

                   $"Dependencies\r\n" +
                   $"============\r\n" +
                   $"read-after-write: {RAW}\r\n" +
                   $"write-after-read: {WAR}\r\n" +
                   $"write-after-write: {WAW}\r\n" +
                   $"\r\n" +

                   $"Cycles Stalled\r\n" +
                   $"==============\r\n" +
                   $"fetch: {fetch}\r\n" +
                   $"decode: {decode}\r\n" +
                   $"execute: {execute}\r\n" +
                   $"store/finish: {store}\r\n" +
                   $"\r\n" +

                   $"Total Cycles\r\n" +
                   $"============\r\n" +
                   $"{cycles}\r\n";

        }//end outputStaticPipelineStats()
        #endregion


        //Instruction Control Logic Methods
        #region LDRER() Method
        /// <summary>
        /// Method for LDRE R,R | LDRE R,Immediate | LDRE R,Memory for ints
        /// </summary>
        /// <param name="pipeInts">Instruction ints</param>
        /// <returns>Value to store in sRegister</returns>
        public static void LDRER(Instruction pipeInts)
        {
            float ret = guiForm.getReg(pipeInts.p1Register);

            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end LDRER()
        #endregion

        #region LDREI() Method
        /// <summary>
        /// Method for LDRE R,R | LDRE R,Immediate | LDRE R,Memory for ints
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in sRegister</returns>
        public static void LDREI(Instruction pipeInts)
        {
            float ret = float.Parse(pipeInts.p1Register.Remove(0, 1));

            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end LDREI()
        #endregion

        #region LDREM() Method
        /// <summary>
        /// Method for LDRE R,R | LDRE R,Immediate | LDRE R,Memory for ints
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in sRegister</returns>
        public static void LDREM(Instruction pipeInts)
        {
            string[] cacheStuff = cacheInfo(pipeInts.p1Register.Remove(0, 1));
            int flag = 0;

            if (string.IsNullOrEmpty(cacheStuff[1]) == false)
            {
                for (int i = 0; i <= Convert.ToInt32(cacheStuff[1], 16) + 1; i++)
                {
                    if (Convert.ToInt32(cacheStuff[1], 16) + 1 == i)
                    {
                        for (int j = 4; j < guiForm.cacheType * 2 + 3; j+=2)
                        {
                            if (guiForm.Cache[i, j] == cacheStuff[0])
                            {
                                if (Convert.ToInt32(guiForm.Cache[i, j - 1]) != 0)
                                flag = 1;
                                guiForm.incrementCacheHits();
                                guiForm.cacheHitOrMiss(1);
                            }
                        }
                    }
                }

                if (flag == 0)
                {
                    int tempa = lru();
                    guiForm.Cache[Convert.ToInt32(cacheStuff[1], 16) + 1, tempa ] = cacheStuff[0];
                    guiForm.Cache[Convert.ToInt32(cacheStuff[1], 16) + 1, tempa - 1] = "1";
                    guiForm.incrementCacheMisses();
                    guiForm.cacheHitOrMiss(0);
                }
            }
            else
            {
                for (int j = 0; j < guiForm.cacheType * 2 + 3; j++)
                {
                    if (guiForm.Cache[1, j] == cacheStuff[2])
                    {
                        flag = 1;
                        guiForm.incrementCacheHits();
                        guiForm.cacheHitOrMiss(1);
                    }
                }

                if(flag==0)
                {
                    int tempa = lru();
                    guiForm.Cache[Convert.ToInt32(1) + 1, tempa] = cacheStuff[0];
                    guiForm.Cache[Convert.ToInt32(1) + 1, tempa - 1] = "1";
                    guiForm.incrementCacheMisses();
                    guiForm.cacheHitOrMiss(0);
                }

            }

            float ret = guiForm.getReg(pipeInts.p1Register);
            string retS = "";

            pipeInts.p1Register = pipeInts.p1Register.Remove(0, 1);
            int temp = Convert.ToInt32(pipeInts.p1Register, 16);

            for (int i = 0; i < 4; i++)
            {
                pipeInts.P1Register = temp.ToString("X5");
                temp++;
                retS += guiForm.getByte(pipeInts.p1Register);
            }

            ret = Convert.ToInt32(retS.Replace(" ", ""), 16);
            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end LDREM()
        #endregion

        #region LDREfloat() Method
        /// <summary>
        /// Method for LDRE R,R | LDRE R,Immediate | LDRE R,Memory for floats
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in sRegister</returns>
        public static void LDREfloat(Instruction pipeInts)
        {
            float ret = guiForm.getReg(pipeInts.p1Register);

            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end LDREfloat()
        #endregion

        #region STRE() Method
        /// <summary>
        /// Method for STRE &R,R instruction
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in memory</returns>
        public static void STRE(Instruction pipeInts)
        {
            int ret = Convert.ToInt32(guiForm.getReg(pipeInts.sRegister));//
            pipeInts.p1Register = pipeInts.p1Register.Remove(0, 1);
            string tempR = "";
            string tempRS = Convert.ToString(ret, 16);
            for (int i = 0; i < 4; i++)
            {

                if (tempRS.Length >= 1)
                {
                    if (tempRS.Length == 1)
                    {
                        tempR = ($"{tempRS[0]}");
                        tempRS = tempRS.Remove(0, 1);
                        if (i >= 1)
                        {
                            int temp = Convert.ToInt32(pipeInts.p1Register, 16);
                            temp++;
                            pipeInts.p1Register = temp.ToString("X5");
                        }
                        guiForm.storeByte(pipeInts.p1Register, tempR);
                    }
                    else
                    {
                        tempR = ($"{tempRS[0]}{tempRS[1]}");
                        tempRS = tempRS.Remove(0, 2);
                        if (i >= 1)
                        {
                            int temp = Convert.ToInt32(pipeInts.p1Register, 16);
                            temp++;
                            pipeInts.p1Register = temp.ToString("X5");
                        }
                        guiForm.storeByte(pipeInts.p1Register, tempR);
                    }
                }

            }


        }//end STRE()
        #endregion

        #region lru() Method
        /// <summary>
        /// Method for lru
        /// </summary>
        /// <returns></returns>
        public static int lru()
        {

            if (guiForm.cacheType == 1)
            {
                return 4;
            }
            else if (guiForm.cacheType == 2)
            {
                if (LRU == 1)
                {
                    LRU = 0;
                    return 6;

                }
                else
                {
                    LRU = 1;
                    return 4;

                }
            }
            else 
            {
                
                if (LRULRU == 1)
                {
                    if (LRU == 1)
                    {
                        LRU = 0;
                        return 10;

                    }
                    else
                    {
                        LRULRU = 0;
                        LRU = 1;
                        return 8;

                    }

                }
                else
                {
                    if (LRU == 1)
                    {
                        LRU = 0;
                        return 6;

                    }
                    else
                    {
                        LRULRU = 1;
                        LRU = 1;
                        return 4;

                    }

                }
            }
        }//end lru()
        #endregion

        #region cacheInfo() Method
        /// <summary>
        /// Method for determining cache information and returning it
        /// </summary>
        /// <param name="address">Address of </param>
        /// <returns>String array of cache info</returns>
        public static string[] cacheInfo(string address)
        {
            int block, entries, ways, blockbit, setbit = 0;
            block = guiForm.cacheLineSize;
            entries = guiForm.cacheEntries;
            ways = guiForm.cacheType;
            int addr = Convert.ToInt32(address, 16);
            string[] ret = new string[3];
            if (block == 4)
            {
                string temp = Convert.ToString(addr & 3, 16);
                ret[2] = temp;
                blockbit = 2;
                if (ways == 4)
                {
                    if (entries == 8)
                    {
                        string tempa = Convert.ToString((addr & 4) >> 2, 16);
                        ret[1] = tempa;
                        setbit = 1;
                    }
                    else
                    {
                        string tempa = Convert.ToString((addr & 12) >> 2, 16);
                        ret[1] = tempa;
                        setbit = 2;
                    }
                }
                else if (ways == 2)
                {
                    if (entries == 4)
                    {
                        string tempa = Convert.ToString((addr & 4) >> 2, 16);
                        ret[1] = tempa;
                        setbit = 1;
                    }
                    else if (entries == 8)
                    {
                        string tempa = Convert.ToString((addr & 12) >> 2, 16);
                        ret[1] = tempa;
                        setbit = 2;
                    }
                    else
                    {
                        string tempa = Convert.ToString((addr & 28) >> 2, 16);
                        ret[1] = tempa;
                        setbit = 3;
                    }
                }
                else
                {
                    if (entries == 4)
                    {
                        string tempa = Convert.ToString((addr & 12) >> 2, 16);
                        ret[1] = tempa;
                        setbit = 2;
                    }
                    else if (entries == 8)
                    {
                        string tempa = Convert.ToString((addr & 28) >> 2, 16);
                        ret[1] = tempa;
                        setbit = 3;
                    }
                    else
                    {
                        string tempa = Convert.ToString((addr & 60) >> 2, 16);
                        ret[1] = tempa;
                        setbit = 4;
                    }
                }

            }
            else if (block == 8)
            {
                string temp = Convert.ToString(addr & 7, 16);
                ret[2] = temp;
                blockbit = 3;
                if (ways == 4)
                {
                    if (entries == 8)
                    {
                        string tempa = Convert.ToString((addr & 8) >> 3, 16);
                        ret[1] = tempa;
                        setbit = 1;
                    }
                    else
                    {
                        string tempa = Convert.ToString((addr & 24) >> 3, 16);
                        ret[1] = tempa;
                        setbit = 2;
                    }
                }
                else if (ways == 2)
                {
                    if (entries == 4)
                    {
                        string tempa = Convert.ToString((addr & 8) >> 3, 16);
                        ret[1] = tempa;
                        setbit = 1;
                    }
                    else if (entries == 8)
                    {
                        string tempa = Convert.ToString((addr & 24) >> 3, 16);
                        ret[1] = tempa;
                        setbit = 2;
                    }
                    else
                    {
                        string tempa = Convert.ToString((addr & 56) >> 3, 16);
                        ret[1] = tempa;
                        setbit = 3;
                    }
                }
                else
                {
                    if (entries == 4)
                    {
                        string tempa = Convert.ToString((addr & 24) >> 3, 16);
                        ret[1] = tempa;
                        setbit = 2;
                    }
                    else if (entries == 8)
                    {
                        string tempa = Convert.ToString((addr & 56) >> 3, 16);
                        ret[1] = tempa;
                        setbit = 3;
                    }
                    else
                    {
                        string tempa = Convert.ToString((addr & 120) >> 3, 16);
                        ret[1] = tempa;
                        setbit = 4;
                    }
                }
            }
            else
            {
                string temp = Convert.ToString(addr & 15, 16);
                ret[2] = temp;
                blockbit = 4;
                if (ways == 4)
                {
                    if (entries == 8)
                    {
                        string tempa = Convert.ToString((addr & 16) >> 4, 16);
                        ret[1] = tempa;
                        setbit = 1;
                    }
                    else
                    {
                        string tempa = Convert.ToString((addr & 48) >> 4, 16);
                        ret[1] = tempa;
                        setbit = 2;
                    }
                }
                else if (ways == 2)
                {
                    if (entries == 4)
                    {
                        string tempa = Convert.ToString((addr & 16) >> 4, 16);
                        ret[1] = tempa;
                        setbit = 1;
                    }
                    else if (entries == 8)
                    {
                        string tempa = Convert.ToString((addr & 48) >> 4, 16);
                        ret[1] = tempa;
                        setbit = 2;
                    }
                    else
                    {
                        string tempa = Convert.ToString((addr & 112) >> 4, 16);
                        ret[1] = tempa;
                        setbit = 3;
                    }
                }
                else
                {
                    if (entries == 4)
                    {
                        string tempa = Convert.ToString((addr & 48) >> 4, 16);
                        ret[1] = tempa;
                        setbit = 2;
                    }
                    else if (entries == 8)
                    {
                        string tempa = Convert.ToString((addr & 112) >> 4, 16);
                        ret[1] = tempa;
                        setbit = 3;
                    }
                    else
                    {
                        string tempa = Convert.ToString((addr & 240) >> 4, 16);
                        ret[1] = tempa;
                        setbit = 4;
                    }
                }
            }

            int tagOffSet = setbit + blockbit;

            switch (tagOffSet)
            {
                case 3:
                    string tempa = Convert.ToString(addr & 1048568, 16);
                    ret[0] = tempa;
                    break;

                case 4:
                    string tempb = Convert.ToString(addr & 1048560, 16);
                    ret[0] = tempb;
                    break;

                case 5:
                    string tempc = Convert.ToString(addr & 1048544, 16);
                    ret[0] = tempc;
                    break;

                case 6:
                    string tempd = Convert.ToString(addr & 1048512, 16);
                    ret[0] = tempd;
                    break;

                case 7:
                    string tempe = Convert.ToString(addr & 1048448, 16);
                    ret[0] = tempe;
                    break;

                case 8:
                    string tempf = Convert.ToString(addr & 1048320, 16);
                    ret[0] = tempf;
                    break;
            }

            return ret;

        }//end cacheInfo()
        #endregion

        #region COMP() Method
        /// <summary>
        /// Method for COMP R,R,R instruction
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <param name="nextInst">Nest instruction to check for branch</param>
        /// <returns>Value to store in sRegister</returns>
        public static void COMP(Instruction pipeInts)
        {
            int temp = Convert.ToInt32(pipeInts.p1Register.Remove(0, 1)) - Convert.ToInt32(pipeInts.p2Register.Remove(0, 1));
            switch (temp)
            {
                case int n when (n > 0):
                    break;

                case int n when (n < 0):
                    guiForm.updateRegister("R2", 1);
                    break;

                case int n when (n == 0):
                    guiForm.updateRegister("R1", 1);
                    break;
            }


            /*if (guiForm.getReg(pipeInts.p1Register) < guiForm.getReg(pipeInts.p2Register))
            {
                guiForm.updateRegister(pipeInts.SRegister, -1);  //Return -1 if p1Register less than p2Register
                guiForm.updateRegister("R1", 0);    //De-activates Z (Zero) flag if operands are not equal
            }
            else if (guiForm.getReg(pipeInts.p1Register) == guiForm.getReg(pipeInts.p2Register))
            {
                guiForm.updateRegister(pipeInts.SRegister, 0);   //Return 0 if p1Register equal to p2Register
                guiForm.updateRegister("R1", 1);    //Activates Z (Zero) flag if operands are equal
            }
            else
            {
                guiForm.updateRegister(pipeInts.SRegister, 1);   //Return 1 if p1Register more than p2Register
                guiForm.updateRegister("R1", 0);    //De-activates Z (Zero) flag if operands are not equal
            }*/

        }//end COMP()
        #endregion

        #region ANDD() Method
        /// <summary>
        /// Method for ANDD R,R,R instruction
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in sRegister</returns>
        public static void ANDD(Instruction pipeInts)
        {
            float ret = Convert.ToInt32(guiForm.getReg(pipeInts.p1Register)) & Convert.ToInt32(guiForm.getReg(pipeInts.p2Register));

            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end ANDD()
        #endregion

        #region OORR() Method
        /// <summary>
        /// Method for OORR R,R,R instruction
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in sRegister</returns>
        public static void OORR(Instruction pipeInts)
        {
            float ret = Convert.ToInt32(guiForm.getReg(pipeInts.p1Register)) | Convert.ToInt32(guiForm.getReg(pipeInts.p2Register));

            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end OORR()
        #endregion

        #region BRGT() Method
        /// <summary>
        /// Method for BRGT R,R instruction
        /// </summary>
        /// <param name="reg1">First register to be compared</param>
        /// <param name="reg2">Second register to be compared</param>
        /// <returns>hether or not reg1 is greater than reg2</returns>
        public static void BRGT(Instruction pipeInts)
        {

            if (guiForm.getReg("R1") == 0 && guiForm.getReg("R2") == 0)
            {
                guiForm.updateRegister("R0", float.Parse(pipeInts.sRegister.Remove(0, 1)));
            }
            else
            {

            }

        }//end BRGT()
        #endregion

        #region BRLT() Method
        /// <summary>
        /// Method for BRLT R,R instruction
        /// </summary>
        /// <param name="reg1">First register to be compared</param>
        /// <param name="reg2">Second register to be compared</param>
        /// <returns>Whether or not reg1 is less than reg2</returns>
        public static void BRLT(Instruction pipeInts)
        {
            if (guiForm.getReg("R1") == 0 && guiForm.getReg("R2") == 1)
            {
                guiForm.updateRegister("R0", float.Parse(pipeInts.sRegister.Remove(0, 1)));
            }
            else
            {

            }//end BRLT()
        }
        #endregion

        #region BREQ() Method
        /// <summary>
        /// Method for BREQ R,R instruction
        /// </summary>
        /// <param name="reg1">First register to be compared</param>
        /// <param name="reg2">Second register to be compared</param>
        /// <returns>Whether or not reg1 is equal to reg2</returns>
        public static void BREQ(Instruction pipeInts)
        {
            if (guiForm.getReg("R1") == 1 && guiForm.getReg("R2") == 0)
            {
                guiForm.updateRegister("R0", float.Parse(pipeInts.sRegister.Remove(0, 1)));
            }
            else
            {

            }

        }//end BREQ()
        #endregion

        #region BRAN() Method
        /// <summary>
        /// Method for BRAN R,R instruction
        /// </summary>
        /// <param name="reg1">First register to be compared</param>
        /// <param name="reg2">Second register to be compared</param>
        /// <returns>???</returns>
        public static void BRAN(Instruction pipeInts)
        {
            //NOT SURE WHAT TO PUT HERE (We may not need registers for this instruction in the first place)
            guiForm.updateRegister("R0", float.Parse(pipeInts.sRegister.Remove(0, 1)));
        }//end BRAN()
        #endregion

        #region ADDI() Method
        /// <summary>
        /// Method for ADDI R,R,R instruction
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in sRegister</returns>
        public static void ADDI(Instruction pipeInts)
        {
            float ret = Convert.ToInt32(guiForm.getReg(pipeInts.p1Register)) + Convert.ToInt32(guiForm.getReg(pipeInts.p2Register));

            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end ADDI()
        #endregion

        #region SUBT() Method
        /// <summary>
        /// Method for SUBT R,R,R instruction
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in sRegister</returns>
        public static void SUBT(Instruction pipeInts)
        {
            float ret = Convert.ToInt32(guiForm.getReg(pipeInts.p1Register)) - Convert.ToInt32(guiForm.getReg(pipeInts.p2Register));

            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end SUBT()
        #endregion

        #region FADD() Method
        /// <summary>
        /// Method for FADD F,F,F instruction
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in sRegister</returns>
        public static void FADD(Instruction pipeInts)
        {
            float ret = guiForm.getReg(pipeInts.p1Register) + guiForm.getReg(pipeInts.p2Register);

            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end FADD()
        #endregion

        #region FSUB() Method
        /// <summary>
        /// Method for FSUB F,F,F instruction
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in sRegister</returns>
        public static void FSUB(Instruction pipeInts)
        {
            float ret = guiForm.getReg(pipeInts.p1Register) - guiForm.getReg(pipeInts.p2Register);

            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end FSUB()
        #endregion

        #region FMUL() Method
        /// <summary>
        /// Method for FMUL F,F,F instruction
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in sRegister</returns>
        public static void FMUL(Instruction pipeInts)
        {
            float ret = guiForm.getReg(pipeInts.p1Register) * guiForm.getReg(pipeInts.p2Register);

            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end FMUL()
        #endregion

        #region FDIV() Method
        /// <summary>
        /// Method for FDIV F,F,F instruction
        /// </summary>
        /// <param name="pipeInts">Instruction to currently execute</param>
        /// <returns>Value to store in sRegister</returns>
        public static void FDIV(Instruction pipeInts)
        {
            float ret = guiForm.getReg(pipeInts.p1Register) / guiForm.getReg(pipeInts.p2Register);

            guiForm.updateRegister(pipeInts.sRegister, ret);

        }//end FDIV()
        #endregion

        #region NOOP() Method
        /// <summary>
        /// Method for NOOP instruction
        /// </summary>
        public static void NOOP()
        {
            //Placeholder method that may not be used

        }//end NOOP()
        #endregion

        #region STOP() Method
        /// <summary>
        /// Method for STOP instruction
        /// </summary>
        public static void STOP()
        {
            //Placeholder method that may not be used

        }//end STOP()
        #endregion

    }//end ProgramController class

}//end Team4_Project4 namespace
