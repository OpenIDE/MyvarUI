using System;
using System.Runtime.InteropServices;

namespace MyvarUI.SDL
{
    public class SdlConstants
    {
        /* General keyboard/mouse state definitions. */
        public const byte SDL_PRESSED = 1;
        public const byte SDL_RELEASED = 0;

        /* Default size is according to SDL2 default. */
        public const int SDL_TEXTEDITINGEVENT_TEXT_SIZE = 32;
        public const int SDL_TEXTINPUTEVENT_TEXT_SIZE = 32;

        public const int SDL_QUERY = -1;
        public const int SDL_IGNORE = 0;
        public const int SDL_DISABLE = 0;
        public const int SDL_ENABLE = 1;

        public static uint SDL_BUTTON(uint X)
        {
            // If only there were a better way of doing this in C#
            return (uint)(1 << ((int)X - 1));
        }

        public const uint SDL_BUTTON_LEFT = 1;
        public const uint SDL_BUTTON_MIDDLE = 2;
        public const uint SDL_BUTTON_RIGHT = 3;
        public const uint SDL_BUTTON_X1 = 4;
        public const uint SDL_BUTTON_X2 = 5;
        public static readonly UInt32 SDL_BUTTON_LMASK = SDL_BUTTON(SDL_BUTTON_LEFT);
        public static readonly UInt32 SDL_BUTTON_MMASK = SDL_BUTTON(SDL_BUTTON_MIDDLE);
        public static readonly UInt32 SDL_BUTTON_RMASK = SDL_BUTTON(SDL_BUTTON_RIGHT);
        public static readonly UInt32 SDL_BUTTON_X1MASK = SDL_BUTTON(SDL_BUTTON_X1);
        public static readonly UInt32 SDL_BUTTON_X2MASK = SDL_BUTTON(SDL_BUTTON_X2);

        public const uint SDL_TOUCH_MOUSEID = uint.MaxValue;


        public const byte SDL_HAT_CENTERED = 0x00;
        public const byte SDL_HAT_UP = 0x01;
        public const byte SDL_HAT_RIGHT = 0x02;
        public const byte SDL_HAT_DOWN = 0x04;
        public const byte SDL_HAT_LEFT = 0x08;
        public const byte SDL_HAT_RIGHTUP = SDL_HAT_RIGHT | SDL_HAT_UP;
        public const byte SDL_HAT_RIGHTDOWN = SDL_HAT_RIGHT | SDL_HAT_DOWN;
        public const byte SDL_HAT_LEFTUP = SDL_HAT_LEFT | SDL_HAT_UP;
        public const byte SDL_HAT_LEFTDOWN = SDL_HAT_LEFT | SDL_HAT_DOWN;

    }

    public enum SdlScancode
    {
        Unknown = 0,

        A = 4,
        B = 5,
        C = 6,
        D = 7,
        E = 8,
        F = 9,
        G = 10,
        H = 11,
        I = 12,
        J = 13,
        K = 14,
        L = 15,
        M = 16,
        N = 17,
        O = 18,
        P = 19,
        Q = 20,
        R = 21,
        S = 22,
        T = 23,
        U = 24,
        V = 25,
        W = 26,
        X = 27,
        Y = 28,
        Z = 29,

        D1 = 30,
        D2 = 31,
        D3 = 32,
        D4 = 33,
        D5 = 34,
        D6 = 35,
        D7 = 36,
        D8 = 37,
        D9 = 38,
        D0 = 39,

        Return = 40,
        Escape = 41,
        Backspace = 42,
        Tab = 43,
        Space = 44,

        Minus = 45,
        Equals = 46,
        Leftbracket = 47,
        Rightbracket = 48,
        Backslash = 49,
        Nonushash = 50,
        Semicolon = 51,
        Apostrophe = 52,
        Grave = 53,
        Comma = 54,
        Period = 55,
        Slash = 56,

        Capslock = 57,

        F1 = 58,
        F2 = 59,
        F3 = 60,
        F4 = 61,
        F5 = 62,
        F6 = 63,
        F7 = 64,
        F8 = 65,
        F9 = 66,
        F10 = 67,
        F11 = 68,
        F12 = 69,

        Printscreen = 70,
        Scrolllock = 71,
        Pause = 72,
        Insert = 73,
        Home = 74,
        Pageup = 75,
        Delete = 76,
        End = 77,
        Pagedown = 78,
        Right = 79,
        Left = 80,
        Down = 81,
        Up = 82,

        Numlockclear = 83,
        KpDivide = 84,
        KpMultiply = 85,
        KpMinus = 86,
        KpPlus = 87,
        KpEnter = 88,
        Kp1 = 89,
        Kp2 = 90,
        Kp3 = 91,
        Kp4 = 92,
        Kp5 = 93,
        Kp6 = 94,
        Kp7 = 95,
        Kp8 = 96,
        Kp9 = 97,
        Kp0 = 98,
        KpPeriod = 99,

        Nonusbackslash = 100,
        Application = 101,
        Power = 102,
        KpEquals = 103,
        F13 = 104,
        F14 = 105,
        F15 = 106,
        F16 = 107,
        F17 = 108,
        F18 = 109,
        F19 = 110,
        F20 = 111,
        F21 = 112,
        F22 = 113,
        F23 = 114,
        F24 = 115,
        Execute = 116,
        Help = 117,
        Menu = 118,
        Select = 119,
        Stop = 120,
        Again = 121,
        Undo = 122,
        Cut = 123,
        Copy = 124,
        Paste = 125,
        Find = 126,
        Mute = 127,
        Volumeup = 128,
        Volumedown = 129,
        /* not sure whether there's a reason to enable these */
        /*	SDL_SCANCODE_LOCKINGCAPSLOCK = 130, */
        /*	SDL_SCANCODE_LOCKINGNUMLOCK = 131, */
        /*	SDL_SCANCODE_LOCKINGSCROLLLOCK = 132, */
        KpComma = 133,
        KpEqualsas400 = 134,

        International1 = 135,
        International2 = 136,
        International3 = 137,
        International4 = 138,
        International5 = 139,
        International6 = 140,
        International7 = 141,
        International8 = 142,
        International9 = 143,
        Lang1 = 144,
        Lang2 = 145,
        Lang3 = 146,
        Lang4 = 147,
        Lang5 = 148,
        Lang6 = 149,
        Lang7 = 150,
        Lang8 = 151,
        Lang9 = 152,

        Alterase = 153,
        Sysreq = 154,
        Cancel = 155,
        Clear = 156,
        Prior = 157,
        Return2 = 158,
        Separator = 159,
        Out = 160,
        Oper = 161,
        Clearagain = 162,
        Crsel = 163,
        Exsel = 164,

        Kp00 = 176,
        Kp000 = 177,
        Thousandsseparator = 178,
        Decimalseparator = 179,
        Currencyunit = 180,
        Currencysubunit = 181,
        KpLeftparen = 182,
        KpRightparen = 183,
        KpLeftbrace = 184,
        KpRightbrace = 185,
        KpTab = 186,
        KpBackspace = 187,
        KpA = 188,
        KpB = 189,
        KpC = 190,
        KpD = 191,
        KpE = 192,
        KpF = 193,
        KpXor = 194,
        KpPower = 195,
        KpPercent = 196,
        KpLess = 197,
        KpGreater = 198,
        KpAmpersand = 199,
        KpDblampersand = 200,
        KpVerticalbar = 201,
        KpDblverticalbar = 202,
        KpColon = 203,
        KpHash = 204,
        KpSpace = 205,
        KpAt = 206,
        KpExclam = 207,
        KpMemstore = 208,
        KpMemrecall = 209,
        KpMemclear = 210,
        KpMemadd = 211,
        KpMemsubtract = 212,
        KpMemmultiply = 213,
        KpMemdivide = 214,
        KpPlusminus = 215,
        KpClear = 216,
        KpClearentry = 217,
        KpBinary = 218,
        KpOctal = 219,
        KpDecimal = 220,
        KpHexadecimal = 221,

        Lctrl = 224,
        Lshift = 225,
        Lalt = 226,
        Lgui = 227,
        Rctrl = 228,
        Rshift = 229,
        Ralt = 230,
        Rgui = 231,

        Mode = 257,

        /* These come from the USB consumer page (0x0C) */
        Audionext = 258,
        Audioprev = 259,
        Audiostop = 260,
        Audioplay = 261,
        Audiomute = 262,
        Mediaselect = 263,
        Www = 264,
        Mail = 265,
        Calculator = 266,
        Computer = 267,
        AcSearch = 268,
        AcHome = 269,
        AcBack = 270,
        AcForward = 271,
        AcStop = 272,
        AcRefresh = 273,
        AcBookmarks = 274,

        /* These come from other sources, and are mostly mac related */
        Brightnessdown = 275,
        Brightnessup = 276,
        Displayswitch = 277,
        Kbdillumtoggle = 278,
        Kbdillumdown = 279,
        Kbdillumup = 280,
        Eject = 281,
        Sleep = 282,

        App1 = 283,
        App2 = 284,

        /* This is not a key, simply marks the number of scancodes
         * so that you know how big to make your arrays. */
        SdlNumScancodes = 512
    }

    public enum SdlKeycode
    {
        SdlkUnknown = 0,

        SdlkReturn = '\r',
        SdlkEscape = 27, // '\033'
        SdlkBackspace = '\b',
        SdlkTab = '\t',
        SdlkSpace = ' ',
        SdlkExclaim = '!',
        SdlkQuotedbl = '"',
        SdlkHash = '#',
        SdlkPercent = '%',
        SdlkDollar = '$',
        SdlkAmpersand = '&',
        SdlkQuote = '\'',
        SdlkLeftparen = '(',
        SdlkRightparen = ')',
        SdlkAsterisk = '*',
        SdlkPlus = '+',
        SdlkComma = ',',
        SdlkMinus = '-',
        SdlkPeriod = '.',
        SdlkSlash = '/',
        Sdlk0 = '0',
        Sdlk1 = '1',
        Sdlk2 = '2',
        Sdlk3 = '3',
        Sdlk4 = '4',
        Sdlk5 = '5',
        Sdlk6 = '6',
        Sdlk7 = '7',
        Sdlk8 = '8',
        Sdlk9 = '9',
        SdlkColon = ':',
        SdlkSemicolon = ';',
        SdlkLess = '<',
        SdlkEquals = '=',
        SdlkGreater = '>',
        SdlkQuestion = '?',
        SdlkAt = '@',
        /*
        Skip uppercase letters
        */
        SdlkLeftbracket = '[',
        SdlkBackslash = '\\',
        SdlkRightbracket = ']',
        SdlkCaret = '^',
        SdlkUnderscore = '_',
        SdlkBackquote = '`',
        SdlkA = 'a',
        SdlkB = 'b',
        SdlkC = 'c',
        SdlkD = 'd',
        SdlkE = 'e',
        SdlkF = 'f',
        SdlkG = 'g',
        SdlkH = 'h',
        SdlkI = 'i',
        SdlkJ = 'j',
        SdlkK = 'k',
        SdlkL = 'l',
        SdlkM = 'm',
        SdlkN = 'n',
        SdlkO = 'o',
        SdlkP = 'p',
        SdlkQ = 'q',
        SdlkR = 'r',
        SdlkS = 's',
        SdlkT = 't',
        SdlkU = 'u',
        SdlkV = 'v',
        SdlkW = 'w',
        SdlkX = 'x',
        SdlkY = 'y',
        SdlkZ = 'z',

        SdlkCapslock = SdlScancode.Capslock | (1 << 30),

        SdlkF1 = SdlScancode.F1 | (1 << 30),
        SdlkF2 = SdlScancode.F2 | (1 << 30),
        SdlkF3 = SdlScancode.F3 | (1 << 30),
        SdlkF4 = SdlScancode.F4 | (1 << 30),
        SdlkF5 = SdlScancode.F5 | (1 << 30),
        SdlkF6 = SdlScancode.F6 | (1 << 30),
        SdlkF7 = SdlScancode.F7 | (1 << 30),
        SdlkF8 = SdlScancode.F8 | (1 << 30),
        SdlkF9 = SdlScancode.F9 | (1 << 30),
        SdlkF10 = SdlScancode.F10 | (1 << 30),
        SdlkF11 = SdlScancode.F11 | (1 << 30),
        SdlkF12 = SdlScancode.F12 | (1 << 30),

        SdlkPrintscreen = SdlScancode.Printscreen | (1 << 30),
        SdlkScrolllock = SdlScancode.Scrolllock | (1 << 30),
        SdlkPause = SdlScancode.Pause | (1 << 30),
        SdlkInsert = SdlScancode.Insert | (1 << 30),
        SdlkHome = SdlScancode.Home | (1 << 30),
        SdlkPageup = SdlScancode.Pageup | (1 << 30),
        SdlkDelete = 127,
        SdlkEnd = SdlScancode.End | (1 << 30),
        SdlkPagedown = SdlScancode.Pagedown | (1 << 30),
        SdlkRight = SdlScancode.Right | (1 << 30),
        SdlkLeft = SdlScancode.Left | (1 << 30),
        SdlkDown = SdlScancode.Down | (1 << 30),
        SdlkUp = SdlScancode.Up | (1 << 30),

        SdlkNumlockclear = SdlScancode.Numlockclear | (1 << 30),
        SdlkKpDivide = SdlScancode.KpDivide | (1 << 30),
        SdlkKpMultiply = SdlScancode.KpMultiply | (1 << 30),
        SdlkKpMinus = SdlScancode.KpMinus | (1 << 30),
        SdlkKpPlus = SdlScancode.KpPlus | (1 << 30),
        SdlkKpEnter = SdlScancode.KpEnter | (1 << 30),
        SdlkKp1 = SdlScancode.Kp1 | (1 << 30),
        SdlkKp2 = SdlScancode.Kp2 | (1 << 30),
        SdlkKp3 = SdlScancode.Kp3 | (1 << 30),
        SdlkKp4 = SdlScancode.Kp4 | (1 << 30),
        SdlkKp5 = SdlScancode.Kp5 | (1 << 30),
        SdlkKp6 = SdlScancode.Kp6 | (1 << 30),
        SdlkKp7 = SdlScancode.Kp7 | (1 << 30),
        SdlkKp8 = SdlScancode.Kp8 | (1 << 30),
        SdlkKp9 = SdlScancode.Kp9 | (1 << 30),
        SdlkKp0 = SdlScancode.Kp0 | (1 << 30),
        SdlkKpPeriod = SdlScancode.KpPeriod | (1 << 30),

        SdlkApplication = SdlScancode.Application | (1 << 30),
        SdlkPower = SdlScancode.Power | (1 << 30),
        SdlkKpEquals = SdlScancode.KpEquals | (1 << 30),
        SdlkF13 = SdlScancode.F13 | (1 << 30),
        SdlkF14 = SdlScancode.F14 | (1 << 30),
        SdlkF15 = SdlScancode.F15 | (1 << 30),
        SdlkF16 = SdlScancode.F16 | (1 << 30),
        SdlkF17 = SdlScancode.F17 | (1 << 30),
        SdlkF18 = SdlScancode.F18 | (1 << 30),
        SdlkF19 = SdlScancode.F19 | (1 << 30),
        SdlkF20 = SdlScancode.F20 | (1 << 30),
        SdlkF21 = SdlScancode.F21 | (1 << 30),
        SdlkF22 = SdlScancode.F22 | (1 << 30),
        SdlkF23 = SdlScancode.F23 | (1 << 30),
        SdlkF24 = SdlScancode.F24 | (1 << 30),
        SdlkExecute = SdlScancode.Execute | (1 << 30),
        SdlkHelp = SdlScancode.Help | (1 << 30),
        SdlkMenu = SdlScancode.Menu | (1 << 30),
        SdlkSelect = SdlScancode.Select | (1 << 30),
        SdlkStop = SdlScancode.Stop | (1 << 30),
        SdlkAgain = SdlScancode.Again | (1 << 30),
        SdlkUndo = SdlScancode.Undo | (1 << 30),
        SdlkCut = SdlScancode.Cut | (1 << 30),
        SdlkCopy = SdlScancode.Copy | (1 << 30),
        SdlkPaste = SdlScancode.Paste | (1 << 30),
        SdlkFind = SdlScancode.Find | (1 << 30),
        SdlkMute = SdlScancode.Mute | (1 << 30),
        SdlkVolumeup = SdlScancode.Volumeup | (1 << 30),
        SdlkVolumedown = SdlScancode.Volumedown | (1 << 30),
        SdlkKpComma = SdlScancode.KpComma | (1 << 30),

        SdlkKpEqualsas400 =
            SdlScancode.KpEqualsas400 | (1 << 30),

        SdlkAlterase = SdlScancode.Alterase | (1 << 30),
        SdlkSysreq = SdlScancode.Sysreq | (1 << 30),
        SdlkCancel = SdlScancode.Cancel | (1 << 30),
        SdlkClear = SdlScancode.Clear | (1 << 30),
        SdlkPrior = SdlScancode.Prior | (1 << 30),
        SdlkReturn2 = SdlScancode.Return2 | (1 << 30),
        SdlkSeparator = SdlScancode.Separator | (1 << 30),
        SdlkOut = SdlScancode.Out | (1 << 30),
        SdlkOper = SdlScancode.Oper | (1 << 30),
        SdlkClearagain = SdlScancode.Clearagain | (1 << 30),
        SdlkCrsel = SdlScancode.Crsel | (1 << 30),
        SdlkExsel = SdlScancode.Exsel | (1 << 30),

        SdlkKp00 = SdlScancode.Kp00 | (1 << 30),
        SdlkKp000 = SdlScancode.Kp000 | (1 << 30),

        SdlkThousandsseparator =
            SdlScancode.Thousandsseparator | (1 << 30),

        SdlkDecimalseparator =
            SdlScancode.Decimalseparator | (1 << 30),
        SdlkCurrencyunit = SdlScancode.Currencyunit | (1 << 30),

        SdlkCurrencysubunit =
            SdlScancode.Currencysubunit | (1 << 30),
        SdlkKpLeftparen = SdlScancode.KpLeftparen | (1 << 30),
        SdlkKpRightparen = SdlScancode.KpRightparen | (1 << 30),
        SdlkKpLeftbrace = SdlScancode.KpLeftbrace | (1 << 30),
        SdlkKpRightbrace = SdlScancode.KpRightbrace | (1 << 30),
        SdlkKpTab = SdlScancode.KpTab | (1 << 30),
        SdlkKpBackspace = SdlScancode.KpBackspace | (1 << 30),
        SdlkKpA = SdlScancode.KpA | (1 << 30),
        SdlkKpB = SdlScancode.KpB | (1 << 30),
        SdlkKpC = SdlScancode.KpC | (1 << 30),
        SdlkKpD = SdlScancode.KpD | (1 << 30),
        SdlkKpE = SdlScancode.KpE | (1 << 30),
        SdlkKpF = SdlScancode.KpF | (1 << 30),
        SdlkKpXor = SdlScancode.KpXor | (1 << 30),
        SdlkKpPower = SdlScancode.KpPower | (1 << 30),
        SdlkKpPercent = SdlScancode.KpPercent | (1 << 30),
        SdlkKpLess = SdlScancode.KpLess | (1 << 30),
        SdlkKpGreater = SdlScancode.KpGreater | (1 << 30),
        SdlkKpAmpersand = SdlScancode.KpAmpersand | (1 << 30),

        SdlkKpDblampersand =
            SdlScancode.KpDblampersand | (1 << 30),

        SdlkKpVerticalbar =
            SdlScancode.KpVerticalbar | (1 << 30),

        SdlkKpDblverticalbar =
            SdlScancode.KpDblverticalbar | (1 << 30),
        SdlkKpColon = SdlScancode.KpColon | (1 << 30),
        SdlkKpHash = SdlScancode.KpHash | (1 << 30),
        SdlkKpSpace = SdlScancode.KpSpace | (1 << 30),
        SdlkKpAt = SdlScancode.KpAt | (1 << 30),
        SdlkKpExclam = SdlScancode.KpExclam | (1 << 30),
        SdlkKpMemstore = SdlScancode.KpMemstore | (1 << 30),
        SdlkKpMemrecall = SdlScancode.KpMemrecall | (1 << 30),
        SdlkKpMemclear = SdlScancode.KpMemclear | (1 << 30),
        SdlkKpMemadd = SdlScancode.KpMemadd | (1 << 30),

        SdlkKpMemsubtract =
            SdlScancode.KpMemsubtract | (1 << 30),

        SdlkKpMemmultiply =
            SdlScancode.KpMemmultiply | (1 << 30),
        SdlkKpMemdivide = SdlScancode.KpMemdivide | (1 << 30),
        SdlkKpPlusminus = SdlScancode.KpPlusminus | (1 << 30),
        SdlkKpClear = SdlScancode.KpClear | (1 << 30),
        SdlkKpClearentry = SdlScancode.KpClearentry | (1 << 30),
        SdlkKpBinary = SdlScancode.KpBinary | (1 << 30),
        SdlkKpOctal = SdlScancode.KpOctal | (1 << 30),
        SdlkKpDecimal = SdlScancode.KpDecimal | (1 << 30),

        SdlkKpHexadecimal =
            SdlScancode.KpHexadecimal | (1 << 30),

        SdlkLctrl = SdlScancode.Lctrl | (1 << 30),
        SdlkLshift = SdlScancode.Lshift | (1 << 30),
        SdlkLalt = SdlScancode.Lalt | (1 << 30),
        SdlkLgui = SdlScancode.Lgui | (1 << 30),
        SdlkRctrl = SdlScancode.Rctrl | (1 << 30),
        SdlkRshift = SdlScancode.Rshift | (1 << 30),
        SdlkRalt = SdlScancode.Ralt | (1 << 30),
        SdlkRgui = SdlScancode.Rgui | (1 << 30),

        SdlkMode = SdlScancode.Mode | (1 << 30),

        SdlkAudionext = SdlScancode.Audionext | (1 << 30),
        SdlkAudioprev = SdlScancode.Audioprev | (1 << 30),
        SdlkAudiostop = SdlScancode.Audiostop | (1 << 30),
        SdlkAudioplay = SdlScancode.Audioplay | (1 << 30),
        SdlkAudiomute = SdlScancode.Audiomute | (1 << 30),
        SdlkMediaselect = SdlScancode.Mediaselect | (1 << 30),
        SdlkWww = SdlScancode.Www | (1 << 30),
        SdlkMail = SdlScancode.Mail | (1 << 30),
        SdlkCalculator = SdlScancode.Calculator | (1 << 30),
        SdlkComputer = SdlScancode.Computer | (1 << 30),
        SdlkAcSearch = SdlScancode.AcSearch | (1 << 30),
        SdlkAcHome = SdlScancode.AcHome | (1 << 30),
        SdlkAcBack = SdlScancode.AcBack | (1 << 30),
        SdlkAcForward = SdlScancode.AcForward | (1 << 30),
        SdlkAcStop = SdlScancode.AcStop | (1 << 30),
        SdlkAcRefresh = SdlScancode.AcRefresh | (1 << 30),
        SdlkAcBookmarks = SdlScancode.AcBookmarks | (1 << 30),

        SdlkBrightnessdown =
            SdlScancode.Brightnessdown | (1 << 30),
        SdlkBrightnessup = SdlScancode.Brightnessup | (1 << 30),
        SdlkDisplayswitch = SdlScancode.Displayswitch | (1 << 30),

        SdlkKbdillumtoggle =
            SdlScancode.Kbdillumtoggle | (1 << 30),
        SdlkKbdillumdown = SdlScancode.Kbdillumdown | (1 << 30),
        SdlkKbdillumup = SdlScancode.Kbdillumup | (1 << 30),
        SdlkEject = SdlScancode.Eject | (1 << 30),
        SdlkSleep = SdlScancode.Sleep | (1 << 30)
    }

    public unsafe struct SdlSurface
    {
        public uint Flags; /**< Read-only */
        public void* Format; /**< Read-only */
        public int W, H; /**< Read-only */
        public int Pitch; /**< Read-only */
        public void* Pixels; /**< Read-write */

        /** Application data associated with the surface */
        public void* Userdata; /**< Read-write */

        /** information needed for surfaces requiring locks */
        public int Locked; /**< Read-only */
        public void* LockData; /**< Read-only */

        /** clipping information */
        public SdlRect ClipRect; /**< Read-only */

        /** info for fast blit mapping to other surfaces */
        public void* Map; /**< Private */

        /** Reference count -- used when freeing surface */
        public int Refcount; /**< Read-mostly */
    }

    public struct SdlRect
    {
        public int X, Y;
        public int W, H;
    }


    [Flags]
    public enum SdlRendererFlags
    {
        SdlRendererSoftware = 0x00000001, /**< The renderer is a software fallback */
        SdlRendererAccelerated = 0x00000002, /**< The renderer uses hardware
                                                     acceleration */
        SdlRendererPresentvsync = 0x00000004, /**< Present is synchronized
                                                     with the refresh rate */
        SdlRendererTargettexture = 0x00000008 /**< The renderer supports
                                                     rendering to texture */
    }

    public enum SdlInit
    {
        SdlInitVideo = 0x00000020
    }

    [Flags]
    public enum SdlWindowFlags
    {
        SdlWindowFullscreen = 0x00000001, /**< fullscreen window */
        SdlWindowOpengl = 0x00000002, /**< window usable with OpenGL context */
        SdlWindowShown = 0x00000004, /**< window is visible */
        SdlWindowHidden = 0x00000008, /**< window is not visible */
        SdlWindowBorderless = 0x00000010, /**< no window decoration */
        SdlWindowResizable = 0x00000020, /**< window can be resized */
        SdlWindowMinimized = 0x00000040, /**< window is minimized */
        SdlWindowMaximized = 0x00000080, /**< window is maximized */
        SdlWindowInputGrabbed = 0x00000100, /**< window has grabbed input focus */
        SdlWindowInputFocus = 0x00000200, /**< window has input focus */
        SdlWindowMouseFocus = 0x00000400, /**< window has mouse focus */
        SdlWindowFullscreenDesktop = (SdlWindowFullscreen | 0x00001000),
        SdlWindowForeign = 0x00000800, /**< window not created by SDL */
        SdlWindowAllowHighdpi = 0x00002000, /**< window should be created in high-DPI mode if supported */
        SdlWindowMouseCapture = 0x00004000 /**< window has mouse captured (unrelated to INPUT_GRABBED) */
    }

    public enum SDL_WindowEventID : byte
    {
        SDL_WINDOWEVENT_NONE,
        SDL_WINDOWEVENT_SHOWN,
        SDL_WINDOWEVENT_HIDDEN,
        SDL_WINDOWEVENT_EXPOSED,
        SDL_WINDOWEVENT_MOVED,
        SDL_WINDOWEVENT_RESIZED,
        SDL_WINDOWEVENT_SIZE_CHANGED,
        SDL_WINDOWEVENT_MINIMIZED,
        SDL_WINDOWEVENT_MAXIMIZED,
        SDL_WINDOWEVENT_RESTORED,
        SDL_WINDOWEVENT_ENTER,
        SDL_WINDOWEVENT_LEAVE,
        SDL_WINDOWEVENT_FOCUS_GAINED,
        SDL_WINDOWEVENT_FOCUS_LOST,
        SDL_WINDOWEVENT_CLOSE,
        /* Available in 2.0.5 or higher */
        SDL_WINDOWEVENT_TAKE_FOCUS,
        SDL_WINDOWEVENT_HIT_TEST
    }

    public enum SdlEventType
    {
        SdlFirstevent = 0, /**< Unused (do not remove) */

        /* Application events */
        SdlQuit = 0x100, /**< User-requested quit */

        /* These application events have special meaning on iOS, see README-ios.md for details */
        SdlAppTerminating, /**< The application is being terminated by the OS
                                     Called on iOS in applicationWillTerminate()
                                     Called on Android in onDestroy()
                                */
        SdlAppLowmemory, /**< The application is low on memory, free memory if possible.
                                     Called on iOS in applicationDidReceiveMemoryWarning()
                                     Called on Android in onLowMemory()
                                */
        SdlAppWillenterbackground, /**< The application is about to enter the background
                                     Called on iOS in applicationWillResignActive()
                                     Called on Android in onPause()
                                */
        SdlAppDidenterbackground, /**< The application did enter the background and may not get CPU for some time
                                     Called on iOS in applicationDidEnterBackground()
                                     Called on Android in onPause()
                                */
        SdlAppWillenterforeground, /**< The application is about to enter the foreground
                                     Called on iOS in applicationWillEnterForeground()
                                     Called on Android in onResume()
                                */
        SdlAppDidenterforeground, /**< The application is now interactive
                                     Called on iOS in applicationDidBecomeActive()
                                     Called on Android in onResume()
                                */

        /* Window events */
        SdlWindowevent = 0x200, /**< Window state change */
        SdlSyswmevent, /**< System specific event */

        /* Keyboard events */
        SdlKeydown = 0x300, /**< Key pressed */
        SdlKeyup, /**< Key released */
        SdlTextediting, /**< Keyboard text editing (composition) */
        SdlTextinput, /**< Keyboard text input */
        SdlKeymapchanged, /**< Keymap changed due to a system event such as an
                                     input language or keyboard layout change.
                                */

        /* Mouse events */
        SdlMousemotion = 0x400, /**< Mouse moved */
        SdlMousebuttondown, /**< Mouse button pressed */
        SdlMousebuttonup, /**< Mouse button released */
        SdlMousewheel, /**< Mouse wheel motion */

        /* Joystick events */
        SdlJoyaxismotion = 0x600, /**< Joystick axis motion */
        SdlJoyballmotion, /**< Joystick trackball motion */
        SdlJoyhatmotion, /**< Joystick hat position change */
        SdlJoybuttondown, /**< Joystick button pressed */
        SdlJoybuttonup, /**< Joystick button released */
        SdlJoydeviceadded, /**< A new joystick has been inserted into the system */
        SdlJoydeviceremoved, /**< An opened joystick has been removed */

        /* Game controller events */
        SdlControlleraxismotion = 0x650, /**< Game controller axis motion */
        SdlControllerbuttondown, /**< Game controller button pressed */
        SdlControllerbuttonup, /**< Game controller button released */
        SdlControllerdeviceadded, /**< A new Game controller has been inserted into the system */
        SdlControllerdeviceremoved, /**< An opened Game controller has been removed */
        SdlControllerdeviceremapped, /**< The controller mapping was updated */

        /* Touch events */
        SdlFingerdown = 0x700,
        SdlFingerup,
        SdlFingermotion,

        /* Gesture events */
        SdlDollargesture = 0x800,
        SdlDollarrecord,
        SdlMultigesture,

        /* Clipboard events */
        SdlClipboardupdate = 0x900, /**< The clipboard changed */

        /* Drag and drop events */
        SdlDropfile = 0x1000, /**< The system requests a file open */

        /* Audio hotplug events */
        SdlAudiodeviceadded = 0x1100, /**< A new audio device is available */
        SdlAudiodeviceremoved, /**< An audio device has been removed. */

        /* Render events */
        SdlRenderTargetsReset = 0x2000,
        /**< The render targets have been reset and their contents need to be updated */
        SdlRenderDeviceReset, /**< The device has been reset and all textures need to be recreated */

        /** Events ::SDL_USEREVENT through ::SDL_LASTEVENT are for your use,
         *  and should be allocated with SDL_RegisterEvents()
         */
        SdlUserevent = 0x8000,

        /**
         *  This last event is only for bounding internal arrays
         */
        SdlLastevent = 0xFFFF
    }

    unsafe struct SdlWindow
    {
        void* _magic;
        uint _id;
        string _title;
        void* _icon;
        int _x, _y;
        int _w, _h;
        int _minW, _minH;
        int _maxW, _maxH;
        uint _flags;
        uint _lastFullscreenFlags;

        /* Stored position and size for windowed mode */
        void* _windowed;

        void* _fullscreenMode;

        float _brightness;
        UInt16* _gamma;
        UInt16* _savedGamma; /* (just offset into gamma) */

        void* _surface;
        void* _surfaceValid;

        void* _isHiding;
        void* _isDestroying;
        void* _shaper;

        void* _hitTest;
        void* _hitTestData;

        void* _data;

        void* _driverdata;

        void* _prev;
        void* _next;
    };

    /* Only available in 2.0.4 or higher */
    public enum SDL_MouseWheelDirection : uint
    {
        SDL_MOUSEHWEEL_NORMAL,
        SDL_MOUSEWHEEL_FLIPPED
    }

    /* Fields shared by every event */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_GenericEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
    }

    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Window state change event data (event.window.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_WindowEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public UInt32 windowID;
        public SDL_WindowEventID windowEvent; // event, lolC#
        private byte padding1;
        private byte padding2;
        private byte padding3;
        public Int32 data1;
        public Int32 data2;
    }
#pragma warning restore 0169

    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Keyboard button event structure (event.key.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_KeyboardEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public UInt32 windowID;
        public byte state;
        public byte repeat; /* non-zero if this is a repeat */
        private byte padding2;
        private byte padding3;
        public SDL_Keysym keysym;
    }
#pragma warning restore 0169

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SDL_TextEditingEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public UInt32 windowID;
        public fixed byte text[SdlConstants.SDL_TEXTEDITINGEVENT_TEXT_SIZE];
        public Int32 start;
        public Int32 length;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SDL_TextInputEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public UInt32 windowID;
        public fixed byte text[SdlConstants.SDL_TEXTINPUTEVENT_TEXT_SIZE];
    }

    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Mouse motion event structure (event.motion.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_MouseMotionEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public UInt32 windowID;
        public UInt32 which;
        public byte state; /* bitmask of buttons */
        private byte padding1;
        private byte padding2;
        private byte padding3;
        public Int32 x;
        public Int32 y;
        public Int32 xrel;
        public Int32 yrel;
    }
#pragma warning restore 0169

    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Mouse button event structure (event.button.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_MouseButtonEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public UInt32 windowID;
        public UInt32 which;
        public byte button; /* button id */
        public byte state; /* SDL_PRESSED or SDL_RELEASED */
        public byte clicks; /* 1 for single-click, 2 for double-click, etc. */
        private byte padding1;
        public Int32 x;
        public Int32 y;
    }
#pragma warning restore 0169

    /* Mouse wheel event structure (event.wheel.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_MouseWheelEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public UInt32 windowID;
        public UInt32 which;
        public Int32 x; /* amount scrolled horizontally */
        public Int32 y; /* amount scrolled vertically */
        public UInt32 direction; /* Set to one of the SDL_MOUSEWHEEL_* defines */
    }

    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Joystick axis motion event structure (event.jaxis.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_JoyAxisEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public Int32 which; /* SDL_JoystickID */
        public byte axis;
        private byte padding1;
        private byte padding2;
        private byte padding3;
        public Int16 axisValue; /* value, lolC# */
        public UInt16 padding4;
    }
#pragma warning restore 0169

    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Joystick trackball motion event structure (event.jball.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_JoyBallEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public Int32 which; /* SDL_JoystickID */
        public byte ball;
        private byte padding1;
        private byte padding2;
        private byte padding3;
        public Int16 xrel;
        public Int16 yrel;
    }
#pragma warning restore 0169

    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Joystick hat position change event struct (event.jhat.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_JoyHatEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public Int32 which; /* SDL_JoystickID */
        public byte hat; /* index of the hat */
        public byte hatValue; /* value, lolC# */
        private byte padding1;
        private byte padding2;
    }
#pragma warning restore 0169

    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Joystick button event structure (event.jbutton.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_JoyButtonEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public Int32 which; /* SDL_JoystickID */
        public byte button;
        public byte state; /* SDL_PRESSED or SDL_RELEASED */
        private byte padding1;
        private byte padding2;
    }
#pragma warning restore 0169

    /* Joystick device event structure (event.jdevice.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_JoyDeviceEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public Int32 which; /* SDL_JoystickID */
    }

    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Game controller axis motion event (event.caxis.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_ControllerAxisEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public Int32 which; /* SDL_JoystickID */
        public byte axis;
        private byte padding1;
        private byte padding2;
        private byte padding3;
        public Int16 axisValue; /* value, lolC# */
        private UInt16 padding4;
    }
#pragma warning restore 0169

    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Game controller button event (event.cbutton.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_ControllerButtonEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public Int32 which; /* SDL_JoystickID */
        public byte button;
        public byte state;
        private byte padding1;
        private byte padding2;
    }
#pragma warning restore 0169

    /* Game controller device event (event.cdevice.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_ControllerDeviceEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public Int32 which; /* joystick id for ADDED,
						 * else instance id
						 */
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_TouchFingerEvent
    {
        public UInt32 type;
        public UInt32 timestamp;
        public Int64 touchId; // SDL_TouchID
        public Int64 fingerId; // SDL_GestureID
        public float x;
        public float y;
        public float dx;
        public float dy;
        public float pressure;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_MultiGestureEvent
    {
        public UInt32 type;
        public UInt32 timestamp;
        public Int64 touchId; // SDL_TouchID
        public float dTheta;
        public float dDist;
        public float x;
        public float y;
        public UInt16 numFingers;
        public UInt16 padding;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_DollarGestureEvent
    {
        public UInt32 type;
        public UInt32 timestamp;
        public Int64 touchId; // SDL_TouchID
        public Int64 gestureId; // SDL_GestureID
        public UInt32 numFingers;
        public float error;
        public float x;
        public float y;
    }

    /* File open request by system (event.drop.*), disabled by
     * default
     */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_DropEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public IntPtr file; /* char* filename, to be freed */
    }

    /* The "quit requested" event */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_QuitEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
    }

    /* A user defined event (event.user.*) */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_UserEvent
    {
        public UInt32 type;
        public UInt32 timestamp;
        public UInt32 windowID;
        public Int32 code;
        public IntPtr data1; /* user-defined */
        public IntPtr data2; /* user-defined */
    }

    /* A video driver dependent event (event.syswm.*), disabled */
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_SysWMEvent
    {
        public SdlEventType type;
        public UInt32 timestamp;
        public IntPtr msg; /* SDL_SysWMmsg*, system-dependent*/
    }

    /* General event structure */
    // C# doesn't do unions, so we do this ugly thing. */
    [StructLayout(LayoutKind.Explicit)]
    public struct SDL_Event
    {
        [FieldOffset(0)]
        public SdlEventType type;
        [FieldOffset(0)]
        public SDL_WindowEvent window;
        [FieldOffset(0)]
        public SDL_KeyboardEvent key;
        [FieldOffset(0)]
        public SDL_TextEditingEvent edit;
        [FieldOffset(0)]
        public SDL_TextInputEvent text;
        [FieldOffset(0)]
        public SDL_MouseMotionEvent motion;
        [FieldOffset(0)]
        public SDL_MouseButtonEvent button;
        [FieldOffset(0)]
        public SDL_MouseWheelEvent wheel;
        [FieldOffset(0)]
        public SDL_JoyAxisEvent jaxis;
        [FieldOffset(0)]
        public SDL_JoyBallEvent jball;
        [FieldOffset(0)]
        public SDL_JoyHatEvent jhat;
        [FieldOffset(0)]
        public SDL_JoyButtonEvent jbutton;
        [FieldOffset(0)]
        public SDL_JoyDeviceEvent jdevice;
        [FieldOffset(0)]
        public SDL_ControllerAxisEvent caxis;
        [FieldOffset(0)]
        public SDL_ControllerButtonEvent cbutton;
        [FieldOffset(0)]
        public SDL_ControllerDeviceEvent cdevice;
        [FieldOffset(0)]
        public SDL_QuitEvent quit;
        [FieldOffset(0)]
        public SDL_UserEvent user;
        [FieldOffset(0)]
        public SDL_SysWMEvent syswm;
        [FieldOffset(0)]
        public SDL_TouchFingerEvent tfinger;
        [FieldOffset(0)]
        public SDL_MultiGestureEvent mgesture;
        [FieldOffset(0)]
        public SDL_DollarGestureEvent dgesture;
        [FieldOffset(0)]
        public SDL_DropEvent drop;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int SDL_EventFilter(
        IntPtr userdata, // void*
        IntPtr sdlevent // SDL_Event* event, lolC#
    );

    public enum SDL_eventaction
    {
        SDL_ADDEVENT,
        SDL_PEEKEVENT,
        SDL_GETEVENT
    }

    #region SDL_keyboard.h

    [Flags]
    public enum SDL_Keymod : ushort
    {
        KMOD_NONE = 0x0000,
        KMOD_LSHIFT = 0x0001,
        KMOD_RSHIFT = 0x0002,
        KMOD_LCTRL = 0x0040,
        KMOD_RCTRL = 0x0080,
        KMOD_LALT = 0x0100,
        KMOD_RALT = 0x0200,
        KMOD_LGUI = 0x0400,
        KMOD_RGUI = 0x0800,
        KMOD_NUM = 0x1000,
        KMOD_CAPS = 0x2000,
        KMOD_MODE = 0x4000,
        KMOD_RESERVED = 0x8000,

        /* These are defines in the SDL headers */
        KMOD_CTRL = (KMOD_LCTRL | KMOD_RCTRL),
        KMOD_SHIFT = (KMOD_LSHIFT | KMOD_RSHIFT),
        KMOD_ALT = (KMOD_LALT | KMOD_RALT),
        KMOD_GUI = (KMOD_LGUI | KMOD_RGUI)
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_Keysym
    {
        public SdlScancode scancode;
        public SdlKeycode sym;
        public SDL_Keymod mod; /* UInt16 */
        public UInt32 unicode; /* Deprecated */
    }

    #endregion

    #region SDL_mouse.c

    /* Note: SDL_Cursor is a typedef normally. We'll treat it as
     * an IntPtr, because C# doesn't do typedefs. Yay!
     */

    /* System cursor types */
    public enum SDL_SystemCursor
    {
        SDL_SYSTEM_CURSOR_ARROW,    // Arrow
        SDL_SYSTEM_CURSOR_IBEAM,    // I-beam
        SDL_SYSTEM_CURSOR_WAIT,     // Wait
        SDL_SYSTEM_CURSOR_CROSSHAIR,    // Crosshair
        SDL_SYSTEM_CURSOR_WAITARROW,    // Small wait cursor (or Wait if not available)
        SDL_SYSTEM_CURSOR_SIZENWSE, // Double arrow pointing northwest and southeast
        SDL_SYSTEM_CURSOR_SIZENESW, // Double arrow pointing northeast and southwest
        SDL_SYSTEM_CURSOR_SIZEWE,   // Double arrow pointing west and east
        SDL_SYSTEM_CURSOR_SIZENS,   // Double arrow pointing north and south
        SDL_SYSTEM_CURSOR_SIZEALL,  // Four pointed arrow pointing north, south, east, and west
        SDL_SYSTEM_CURSOR_NO,       // Slashed circle or crossbones
        SDL_SYSTEM_CURSOR_HAND,     // Hand
        SDL_NUM_SYSTEM_CURSORS
    }

    #endregion

    #region SDL_touch.h

    public struct SDL_Finger
    {
        public long id; // SDL_FingerID
        public float x;
        public float y;
        public float pressure;
    }

    #endregion

    #region SDL_joystick.h

    public enum SDL_JoystickPowerLevel
    {
        SDL_JOYSTICK_POWER_UNKNOWN = -1,
        SDL_JOYSTICK_POWER_EMPTY,
        SDL_JOYSTICK_POWER_LOW,
        SDL_JOYSTICK_POWER_MEDIUM,
        SDL_JOYSTICK_POWER_FULL,
        SDL_JOYSTICK_POWER_WIRED,
        SDL_JOYSTICK_POWER_MAX
    }

    #endregion

    #region SDL_gamecontroller.h

    public enum SDL_GameControllerBindType
    {
        SDL_CONTROLLER_BINDTYPE_NONE,
        SDL_CONTROLLER_BINDTYPE_BUTTON,
        SDL_CONTROLLER_BINDTYPE_AXIS,
        SDL_CONTROLLER_BINDTYPE_HAT
    }

    public enum SDL_GameControllerAxis
    {
        SDL_CONTROLLER_AXIS_INVALID = -1,
        SDL_CONTROLLER_AXIS_LEFTX,
        SDL_CONTROLLER_AXIS_LEFTY,
        SDL_CONTROLLER_AXIS_RIGHTX,
        SDL_CONTROLLER_AXIS_RIGHTY,
        SDL_CONTROLLER_AXIS_TRIGGERLEFT,
        SDL_CONTROLLER_AXIS_TRIGGERRIGHT,
        SDL_CONTROLLER_AXIS_MAX
    }

    public enum SDL_GameControllerButton
    {
        SDL_CONTROLLER_BUTTON_INVALID = -1,
        SDL_CONTROLLER_BUTTON_A,
        SDL_CONTROLLER_BUTTON_B,
        SDL_CONTROLLER_BUTTON_X,
        SDL_CONTROLLER_BUTTON_Y,
        SDL_CONTROLLER_BUTTON_BACK,
        SDL_CONTROLLER_BUTTON_GUIDE,
        SDL_CONTROLLER_BUTTON_START,
        SDL_CONTROLLER_BUTTON_LEFTSTICK,
        SDL_CONTROLLER_BUTTON_RIGHTSTICK,
        SDL_CONTROLLER_BUTTON_LEFTSHOULDER,
        SDL_CONTROLLER_BUTTON_RIGHTSHOULDER,
        SDL_CONTROLLER_BUTTON_DPAD_UP,
        SDL_CONTROLLER_BUTTON_DPAD_DOWN,
        SDL_CONTROLLER_BUTTON_DPAD_LEFT,
        SDL_CONTROLLER_BUTTON_DPAD_RIGHT,
        SDL_CONTROLLER_BUTTON_MAX,
    }

    // FIXME: I'd rather this somehow be private...
    [StructLayout(LayoutKind.Sequential)]
    public struct INTERNAL_GameControllerButtonBind_hat
    {
        public int hat;
        public int hat_mask;
    }

    /* This struct has a union in it, hence the Explicit layout. */
    [StructLayout(LayoutKind.Explicit)]
    public struct SDL_GameControllerButtonBind
    {
        /* Note: enum size is 4 bytes. */
        [FieldOffset(0)]
        public SDL_GameControllerBindType bindType;
        [FieldOffset(4)]
        public int button;
        [FieldOffset(4)]
        public int axis;
        [FieldOffset(4)]
        public INTERNAL_GameControllerButtonBind_hat hat;
    }

	#endregion

	#region SDL_rect.h

	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_Point
	{
		public int x;
		public int y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_Rect
	{
		public int x;
		public int y;
		public int w;
		public int h;
	}

	#endregion

	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_Surface
	{
		public uint flags;
		public IntPtr format; // SDL_PixelFormat*
		public int w;
		public int h;
		public int pitch;
		public IntPtr pixels; // void*
		public IntPtr userdata; // void*
		public int locked;
		public IntPtr lock_data; // void*
		public SDL_Rect clip_rect;
		public IntPtr map; // SDL_BlitMap*
		public int refcount;
	}
}