﻿using System.Collections.Generic;
using Avalonia.Gtk3;
using Avalonia.Input;

namespace Avalonia.Gtk.Common
{
    static class KeyTransform
    {
        private static readonly Dictionary<GdkKey, Key> KeyDic = new Dictionary<GdkKey, Key>
        {
            { GdkKey.Cancel, Key.Cancel },
            { GdkKey.BackSpace, Key.Back },
            { GdkKey.Tab, Key.Tab },
            { GdkKey.Linefeed, Key.LineFeed },
            { GdkKey.Clear, Key.Clear },
            { GdkKey.Return, Key.Return },
            { GdkKey.KP_Enter, Key.Return },
            { GdkKey.Pause, Key.Pause },
            { GdkKey.Caps_Lock, Key.CapsLock },
            //{ GdkKey.?, Key.HangulMode }
            //{ GdkKey.?, Key.JunjaMode }
            //{ GdkKey.?, Key.FinalMode }
            //{ GdkKey.?, Key.KanjiMode }
            { GdkKey.Escape, Key.Escape },
            //{ GdkKey.?, Key.ImeConvert }
            //{ GdkKey.?, Key.ImeNonConvert }
            //{ GdkKey.?, Key.ImeAccept }
            //{ GdkKey.?, Key.ImeModeChange }
            { GdkKey.space, Key.Space },
            { GdkKey.Prior, Key.Prior },
            { GdkKey.KP_Prior, Key.Prior },
            { GdkKey.Page_Down, Key.PageDown },
            { GdkKey.KP_Page_Down, Key.PageDown },
            { GdkKey.End, Key.End },
            { GdkKey.KP_End, Key.End },
            { GdkKey.Home, Key.Home },
            { GdkKey.KP_Home, Key.Home },
            { GdkKey.Left, Key.Left },
            { GdkKey.KP_Left, Key.Left },
            { GdkKey.Up, Key.Up },
            { GdkKey.KP_Up, Key.Up },
            { GdkKey.Right, Key.Right },
            { GdkKey.KP_Right, Key.Right },
            { GdkKey.Down, Key.Down },
            { GdkKey.KP_Down, Key.Down },
            { GdkKey.Select, Key.Select },
            { GdkKey.Print, Key.Print },
            { GdkKey.Execute, Key.Execute },
            //{ GdkKey.?, Key.Snapshot }
            { GdkKey.Insert, Key.Insert },
            { GdkKey.KP_Insert, Key.Insert },
            { GdkKey.Delete, Key.Delete },
            { GdkKey.KP_Delete, Key.Delete },
            { GdkKey.Help, Key.Help },
            { GdkKey.Key_0, Key.D0 },
            { GdkKey.Key_1, Key.D1 },
            { GdkKey.Key_2, Key.D2 },
            { GdkKey.Key_3, Key.D3 },
            { GdkKey.Key_4, Key.D4 },
            { GdkKey.Key_5, Key.D5 },
            { GdkKey.Key_6, Key.D6 },
            { GdkKey.Key_7, Key.D7 },
            { GdkKey.Key_8, Key.D8 },
            { GdkKey.Key_9, Key.D9 },
            { GdkKey.A, Key.A },
            { GdkKey.B, Key.B },
            { GdkKey.C, Key.C },
            { GdkKey.D, Key.D },
            { GdkKey.E, Key.E },
            { GdkKey.F, Key.F },
            { GdkKey.G, Key.G },
            { GdkKey.H, Key.H },
            { GdkKey.I, Key.I },
            { GdkKey.J, Key.J },
            { GdkKey.K, Key.K },
            { GdkKey.L, Key.L },
            { GdkKey.M, Key.M },
            { GdkKey.N, Key.N },
            { GdkKey.O, Key.O },
            { GdkKey.P, Key.P },
            { GdkKey.Q, Key.Q },
            { GdkKey.R, Key.R },
            { GdkKey.S, Key.S },
            { GdkKey.T, Key.T },
            { GdkKey.U, Key.U },
            { GdkKey.V, Key.V },
            { GdkKey.W, Key.W },
            { GdkKey.X, Key.X },
            { GdkKey.Y, Key.Y },
            { GdkKey.Z, Key.Z },
            { GdkKey.a, Key.A },
            { GdkKey.b, Key.B },
            { GdkKey.c, Key.C },
            { GdkKey.d, Key.D },
            { GdkKey.e, Key.E },
            { GdkKey.f, Key.F },
            { GdkKey.g, Key.G },
            { GdkKey.h, Key.H },
            { GdkKey.i, Key.I },
            { GdkKey.j, Key.J },
            { GdkKey.k, Key.K },
            { GdkKey.l, Key.L },
            { GdkKey.m, Key.M },
            { GdkKey.n, Key.N },
            { GdkKey.o, Key.O },
            { GdkKey.p, Key.P },
            { GdkKey.q, Key.Q },
            { GdkKey.r, Key.R },
            { GdkKey.s, Key.S },
            { GdkKey.t, Key.T },
            { GdkKey.u, Key.U },
            { GdkKey.v, Key.V },
            { GdkKey.w, Key.W },
            { GdkKey.x, Key.X },
            { GdkKey.y, Key.Y },
            { GdkKey.z, Key.Z },
            //{ GdkKey.?, Key.LWin }
            //{ GdkKey.?, Key.RWin }
            { GdkKey.Menu, Key.Apps },
            //{ GdkKey.?, Key.Sleep }
            { GdkKey.KP_0, Key.NumPad0 },
            { GdkKey.KP_1, Key.NumPad1 },
            { GdkKey.KP_2, Key.NumPad2 },
            { GdkKey.KP_3, Key.NumPad3 },
            { GdkKey.KP_4, Key.NumPad4 },
            { GdkKey.KP_5, Key.NumPad5 },
            { GdkKey.KP_6, Key.NumPad6 },
            { GdkKey.KP_7, Key.NumPad7 },
            { GdkKey.KP_8, Key.NumPad8 },
            { GdkKey.KP_9, Key.NumPad9 },
            { GdkKey.multiply, Key.Multiply },
            { GdkKey.KP_Multiply, Key.Multiply },
            { GdkKey.KP_Add, Key.Add },
            //{ GdkKey.?, Key.Separator }
            { GdkKey.KP_Subtract, Key.Subtract },
            { GdkKey.KP_Decimal, Key.Decimal },
            { GdkKey.KP_Divide, Key.Divide },
            { GdkKey.F1, Key.F1 },
            { GdkKey.F2, Key.F2 },
            { GdkKey.F3, Key.F3 },
            { GdkKey.F4, Key.F4 },
            { GdkKey.F5, Key.F5 },
            { GdkKey.F6, Key.F6 },
            { GdkKey.F7, Key.F7 },
            { GdkKey.F8, Key.F8 },
            { GdkKey.F9, Key.F9 },
            { GdkKey.F10, Key.F10 },
            { GdkKey.F11, Key.F11 },
            { GdkKey.F12, Key.F12 },
            { GdkKey.L3, Key.F13 },
            { GdkKey.F14, Key.F14 },
            { GdkKey.L5, Key.F15 },
            { GdkKey.F16, Key.F16 },
            { GdkKey.F17, Key.F17 },
            { GdkKey.L8, Key.F18 },
            { GdkKey.L9, Key.F19 },
            { GdkKey.L10, Key.F20 },
            { GdkKey.R1, Key.F21 },
            { GdkKey.R2, Key.F22 },
            { GdkKey.F23, Key.F23 },
            { GdkKey.R4, Key.F24 },
            { GdkKey.Num_Lock, Key.NumLock },
            { GdkKey.Scroll_Lock, Key.Scroll },
            { GdkKey.Shift_L, Key.LeftShift },
            { GdkKey.Shift_R, Key.RightShift },
            { GdkKey.Control_L, Key.LeftCtrl },
            { GdkKey.Control_R, Key.RightCtrl },
            { GdkKey.Alt_L, Key.LeftAlt },
            { GdkKey.Alt_R, Key.RightAlt },
            //{ GdkKey.?, Key.BrowserBack }
            //{ GdkKey.?, Key.BrowserForward }
            //{ GdkKey.?, Key.BrowserRefresh }
            //{ GdkKey.?, Key.BrowserStop }
            //{ GdkKey.?, Key.BrowserSearch }
            //{ GdkKey.?, Key.BrowserFavorites }
            //{ GdkKey.?, Key.BrowserHome }
            //{ GdkKey.?, Key.VolumeMute }
            //{ GdkKey.?, Key.VolumeDown }
            //{ GdkKey.?, Key.VolumeUp }
            //{ GdkKey.?, Key.MediaNextTrack }
            //{ GdkKey.?, Key.MediaPreviousTrack }
            //{ GdkKey.?, Key.MediaStop }
            //{ GdkKey.?, Key.MediaPlayPause }
            //{ GdkKey.?, Key.LaunchMail }
            //{ GdkKey.?, Key.SelectMedia }
            //{ GdkKey.?, Key.LaunchApplication1 }
            //{ GdkKey.?, Key.LaunchApplication2 }
            { GdkKey.semicolon, Key.OemSemicolon },
            { GdkKey.plus, Key.OemPlus },
            { GdkKey.equal, Key.OemPlus },
            { GdkKey.comma, Key.OemComma },
            { GdkKey.minus, Key.OemMinus },
            { GdkKey.period, Key.OemPeriod },
            { GdkKey.slash, Key.Oem2 },
            { GdkKey.grave, Key.OemTilde },
            //{ GdkKey.?, Key.AbntC1 }
            //{ GdkKey.?, Key.AbntC2 }
            { GdkKey.bracketleft, Key.OemOpenBrackets },
            { GdkKey.backslash, Key.OemPipe },
            { GdkKey.bracketright, Key.OemCloseBrackets },
            { GdkKey.apostrophe, Key.OemQuotes },
            //{ GdkKey.?, Key.Oem8 }
            //{ GdkKey.?, Key.Oem102 }
            //{ GdkKey.?, Key.ImeProcessed }
            //{ GdkKey.?, Key.System }
            //{ GdkKey.?, Key.OemAttn }
            //{ GdkKey.?, Key.OemFinish }
            //{ GdkKey.?, Key.DbeHiragana }
            //{ GdkKey.?, Key.OemAuto }
            //{ GdkKey.?, Key.DbeDbcsChar }
            //{ GdkKey.?, Key.OemBackTab }
            //{ GdkKey.?, Key.Attn }
            //{ GdkKey.?, Key.DbeEnterWordRegisterMode }
            //{ GdkKey.?, Key.DbeEnterImeConfigureMode }
            //{ GdkKey.?, Key.EraseEof }
            //{ GdkKey.?, Key.Play }
            //{ GdkKey.?, Key.Zoom }
            //{ GdkKey.?, Key.NoName }
            //{ GdkKey.?, Key.DbeEnterDialogConversionMode }
            //{ GdkKey.?, Key.OemClear }
            //{ GdkKey.?, Key.DeadCharProcessed }
        };

        public static Key ConvertKey(GdkKey key)
        {
            Key result;
            return KeyDic.TryGetValue(key, out result) ? result : Key.None;
        }
    }
}
