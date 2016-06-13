using System;
using System.Collections.Generic;
using System.Text;
using ScottsUtils;

namespace WinMac
{
    class AllKey
    {
        public string Desc;
        public WinAPI.KeyCode Code;

        public AllKey(string desc, WinAPI.KeyCode code)
        {
            Desc = desc;
            Code = code;
        }

        public static AllKey[] AllKeys = { 
            new AllKey("Backspace",WinAPI.KeyCode.Backspace),
            new AllKey("Add",WinAPI.KeyCode.Add),
            new AllKey("Cancel",WinAPI.KeyCode.Cancel),
            new AllKey("Clear",WinAPI.KeyCode.Clear),
            new AllKey("Decimal",WinAPI.KeyCode.Decimal),
            new AllKey("Delete",WinAPI.KeyCode.Delete),
            new AllKey("Divide",WinAPI.KeyCode.Divide),
            new AllKey("Down",WinAPI.KeyCode.Down),
            new AllKey("End",WinAPI.KeyCode.End),
            new AllKey("Escape",WinAPI.KeyCode.Escape),
            new AllKey("Home",WinAPI.KeyCode.Home),
            new AllKey("Left",WinAPI.KeyCode.Left),
            new AllKey("Multiply",WinAPI.KeyCode.Multiply),
            new AllKey("Page Down",WinAPI.KeyCode.PageDown),
            new AllKey("Page Up",WinAPI.KeyCode.PageUp),
            new AllKey("Return",WinAPI.KeyCode.Return),
            new AllKey("Right",WinAPI.KeyCode.Right),
            new AllKey("Separator",WinAPI.KeyCode.Separator),
            new AllKey("Space",WinAPI.KeyCode.Space),
            new AllKey("Subtract",WinAPI.KeyCode.Subtract),
            new AllKey("Tab",WinAPI.KeyCode.Tab),
            new AllKey("Up",WinAPI.KeyCode.Up),
            new AllKey("0",WinAPI.KeyCode.Num0),
            new AllKey("1",WinAPI.KeyCode.Num1),
            new AllKey("2",WinAPI.KeyCode.Num2),
            new AllKey("3",WinAPI.KeyCode.Num3),
            new AllKey("4",WinAPI.KeyCode.Num4),
            new AllKey("5",WinAPI.KeyCode.Num5),
            new AllKey("6",WinAPI.KeyCode.Num6),
            new AllKey("7",WinAPI.KeyCode.Num7),
            new AllKey("8",WinAPI.KeyCode.Num8),
            new AllKey("9",WinAPI.KeyCode.Num9),
            new AllKey("A",WinAPI.KeyCode.LetA),
            new AllKey("B",WinAPI.KeyCode.LetB),
            new AllKey("C",WinAPI.KeyCode.LetC),
            new AllKey("D",WinAPI.KeyCode.LetD),
            new AllKey("E",WinAPI.KeyCode.LetE),
            new AllKey("F",WinAPI.KeyCode.LetF),
            new AllKey("G",WinAPI.KeyCode.LetG),
            new AllKey("H",WinAPI.KeyCode.LetH),
            new AllKey("I",WinAPI.KeyCode.LetI),
            new AllKey("J",WinAPI.KeyCode.LetJ),
            new AllKey("K",WinAPI.KeyCode.LetK),
            new AllKey("L",WinAPI.KeyCode.LetL),
            new AllKey("M",WinAPI.KeyCode.LetM),
            new AllKey("N",WinAPI.KeyCode.LetN),
            new AllKey("O",WinAPI.KeyCode.LetO),
            new AllKey("P",WinAPI.KeyCode.LetP),
            new AllKey("Q",WinAPI.KeyCode.LetQ),
            new AllKey("R",WinAPI.KeyCode.LetR),
            new AllKey("S",WinAPI.KeyCode.LetS),
            new AllKey("T",WinAPI.KeyCode.LetT),
            new AllKey("U",WinAPI.KeyCode.LetU),
            new AllKey("V",WinAPI.KeyCode.LetV),
            new AllKey("W",WinAPI.KeyCode.LetW),
            new AllKey("X",WinAPI.KeyCode.LetX),
            new AllKey("Y",WinAPI.KeyCode.LetY),
            new AllKey("Z",WinAPI.KeyCode.LetZ),
            new AllKey("F1",WinAPI.KeyCode.F1),
            new AllKey("F2",WinAPI.KeyCode.F2),
            new AllKey("F3",WinAPI.KeyCode.F3),
            new AllKey("F4",WinAPI.KeyCode.F4),
            new AllKey("F5",WinAPI.KeyCode.F5),
            new AllKey("F6",WinAPI.KeyCode.F6),
            new AllKey("F7",WinAPI.KeyCode.F7),
            new AllKey("F8",WinAPI.KeyCode.F8),
            new AllKey("F9",WinAPI.KeyCode.F9),
            new AllKey("F10",WinAPI.KeyCode.F10),
            new AllKey("F11",WinAPI.KeyCode.F11),
            new AllKey("Numpad 0",WinAPI.KeyCode.NumPad0),
            new AllKey("Numpad 1",WinAPI.KeyCode.NumPad1),
            new AllKey("Numpad 2",WinAPI.KeyCode.NumPad2),
            new AllKey("Numpad 3",WinAPI.KeyCode.NumPad3),
            new AllKey("Numpad 4",WinAPI.KeyCode.NumPad4),
            new AllKey("Numpad 5",WinAPI.KeyCode.NumPad5),
            new AllKey("Numpad 6",WinAPI.KeyCode.NumPad6),
            new AllKey("Numpad 7",WinAPI.KeyCode.NumPad7),
            new AllKey("Numpad 8",WinAPI.KeyCode.NumPad8),
            new AllKey("Numpad 9",WinAPI.KeyCode.NumPad9),
            new AllKey("Volume Mute", WinAPI.KeyCode.VolumeMute),
            new AllKey("Volume Down", WinAPI.KeyCode.VolumeDown),
            new AllKey("Volume Up", WinAPI.KeyCode.VolumeUp),
            new AllKey("Next Track", WinAPI.KeyCode.MediaNextTrack),
            new AllKey("Previous Track", WinAPI.KeyCode.MediaPrevTrack),
            new AllKey("Stop Media", WinAPI.KeyCode.MediaStop),
            new AllKey("Pause Media", WinAPI.KeyCode.MediaPlayPause),
            new AllKey("Launch Mail", WinAPI.KeyCode.LaunchMail),
            new AllKey("Launch Media", WinAPI.KeyCode.LaunchMediaSelect),
            new AllKey("Launch App 1", WinAPI.KeyCode.LaunchApp1),
            new AllKey("Launch App 2", WinAPI.KeyCode.LaunchApp1),
                                    };
    }
}
