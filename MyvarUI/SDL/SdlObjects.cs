using System;
using System.Runtime.InteropServices;

namespace MyvarUI.SDL
{
    public enum SdlScancode
    {
        SdlScancodeUnknown = 0,

        SdlScancodeA = 4,
        SdlScancodeB = 5,
        SdlScancodeC = 6,
        SdlScancodeD = 7,
        SdlScancodeE = 8,
        SdlScancodeF = 9,
        SdlScancodeG = 10,
        SdlScancodeH = 11,
        SdlScancodeI = 12,
        SdlScancodeJ = 13,
        SdlScancodeK = 14,
        SdlScancodeL = 15,
        SdlScancodeM = 16,
        SdlScancodeN = 17,
        SdlScancodeO = 18,
        SdlScancodeP = 19,
        SdlScancodeQ = 20,
        SdlScancodeR = 21,
        SdlScancodeS = 22,
        SdlScancodeT = 23,
        SdlScancodeU = 24,
        SdlScancodeV = 25,
        SdlScancodeW = 26,
        SdlScancodeX = 27,
        SdlScancodeY = 28,
        SdlScancodeZ = 29,

        SdlScancode1 = 30,
        SdlScancode2 = 31,
        SdlScancode3 = 32,
        SdlScancode4 = 33,
        SdlScancode5 = 34,
        SdlScancode6 = 35,
        SdlScancode7 = 36,
        SdlScancode8 = 37,
        SdlScancode9 = 38,
        SdlScancode0 = 39,

        SdlScancodeReturn = 40,
        SdlScancodeEscape = 41,
        SdlScancodeBackspace = 42,
        SdlScancodeTab = 43,
        SdlScancodeSpace = 44,

        SdlScancodeMinus = 45,
        SdlScancodeEquals = 46,
        SdlScancodeLeftbracket = 47,
        SdlScancodeRightbracket = 48,
        SdlScancodeBackslash = 49,
        SdlScancodeNonushash = 50,
        SdlScancodeSemicolon = 51,
        SdlScancodeApostrophe = 52,
        SdlScancodeGrave = 53,
        SdlScancodeComma = 54,
        SdlScancodePeriod = 55,
        SdlScancodeSlash = 56,

        SdlScancodeCapslock = 57,

        SdlScancodeF1 = 58,
        SdlScancodeF2 = 59,
        SdlScancodeF3 = 60,
        SdlScancodeF4 = 61,
        SdlScancodeF5 = 62,
        SdlScancodeF6 = 63,
        SdlScancodeF7 = 64,
        SdlScancodeF8 = 65,
        SdlScancodeF9 = 66,
        SdlScancodeF10 = 67,
        SdlScancodeF11 = 68,
        SdlScancodeF12 = 69,

        SdlScancodePrintscreen = 70,
        SdlScancodeScrolllock = 71,
        SdlScancodePause = 72,
        SdlScancodeInsert = 73,
        SdlScancodeHome = 74,
        SdlScancodePageup = 75,
        SdlScancodeDelete = 76,
        SdlScancodeEnd = 77,
        SdlScancodePagedown = 78,
        SdlScancodeRight = 79,
        SdlScancodeLeft = 80,
        SdlScancodeDown = 81,
        SdlScancodeUp = 82,

        SdlScancodeNumlockclear = 83,
        SdlScancodeKpDivide = 84,
        SdlScancodeKpMultiply = 85,
        SdlScancodeKpMinus = 86,
        SdlScancodeKpPlus = 87,
        SdlScancodeKpEnter = 88,
        SdlScancodeKp1 = 89,
        SdlScancodeKp2 = 90,
        SdlScancodeKp3 = 91,
        SdlScancodeKp4 = 92,
        SdlScancodeKp5 = 93,
        SdlScancodeKp6 = 94,
        SdlScancodeKp7 = 95,
        SdlScancodeKp8 = 96,
        SdlScancodeKp9 = 97,
        SdlScancodeKp0 = 98,
        SdlScancodeKpPeriod = 99,

        SdlScancodeNonusbackslash = 100,
        SdlScancodeApplication = 101,
        SdlScancodePower = 102,
        SdlScancodeKpEquals = 103,
        SdlScancodeF13 = 104,
        SdlScancodeF14 = 105,
        SdlScancodeF15 = 106,
        SdlScancodeF16 = 107,
        SdlScancodeF17 = 108,
        SdlScancodeF18 = 109,
        SdlScancodeF19 = 110,
        SdlScancodeF20 = 111,
        SdlScancodeF21 = 112,
        SdlScancodeF22 = 113,
        SdlScancodeF23 = 114,
        SdlScancodeF24 = 115,
        SdlScancodeExecute = 116,
        SdlScancodeHelp = 117,
        SdlScancodeMenu = 118,
        SdlScancodeSelect = 119,
        SdlScancodeStop = 120,
        SdlScancodeAgain = 121,
        SdlScancodeUndo = 122,
        SdlScancodeCut = 123,
        SdlScancodeCopy = 124,
        SdlScancodePaste = 125,
        SdlScancodeFind = 126,
        SdlScancodeMute = 127,
        SdlScancodeVolumeup = 128,
        SdlScancodeVolumedown = 129,
        /* not sure whether there's a reason to enable these */
        /*	SDL_SCANCODE_LOCKINGCAPSLOCK = 130, */
        /*	SDL_SCANCODE_LOCKINGNUMLOCK = 131, */
        /*	SDL_SCANCODE_LOCKINGSCROLLLOCK = 132, */
        SdlScancodeKpComma = 133,
        SdlScancodeKpEqualsas400 = 134,

        SdlScancodeInternational1 = 135,
        SdlScancodeInternational2 = 136,
        SdlScancodeInternational3 = 137,
        SdlScancodeInternational4 = 138,
        SdlScancodeInternational5 = 139,
        SdlScancodeInternational6 = 140,
        SdlScancodeInternational7 = 141,
        SdlScancodeInternational8 = 142,
        SdlScancodeInternational9 = 143,
        SdlScancodeLang1 = 144,
        SdlScancodeLang2 = 145,
        SdlScancodeLang3 = 146,
        SdlScancodeLang4 = 147,
        SdlScancodeLang5 = 148,
        SdlScancodeLang6 = 149,
        SdlScancodeLang7 = 150,
        SdlScancodeLang8 = 151,
        SdlScancodeLang9 = 152,

        SdlScancodeAlterase = 153,
        SdlScancodeSysreq = 154,
        SdlScancodeCancel = 155,
        SdlScancodeClear = 156,
        SdlScancodePrior = 157,
        SdlScancodeReturn2 = 158,
        SdlScancodeSeparator = 159,
        SdlScancodeOut = 160,
        SdlScancodeOper = 161,
        SdlScancodeClearagain = 162,
        SdlScancodeCrsel = 163,
        SdlScancodeExsel = 164,

        SdlScancodeKp00 = 176,
        SdlScancodeKp000 = 177,
        SdlScancodeThousandsseparator = 178,
        SdlScancodeDecimalseparator = 179,
        SdlScancodeCurrencyunit = 180,
        SdlScancodeCurrencysubunit = 181,
        SdlScancodeKpLeftparen = 182,
        SdlScancodeKpRightparen = 183,
        SdlScancodeKpLeftbrace = 184,
        SdlScancodeKpRightbrace = 185,
        SdlScancodeKpTab = 186,
        SdlScancodeKpBackspace = 187,
        SdlScancodeKpA = 188,
        SdlScancodeKpB = 189,
        SdlScancodeKpC = 190,
        SdlScancodeKpD = 191,
        SdlScancodeKpE = 192,
        SdlScancodeKpF = 193,
        SdlScancodeKpXor = 194,
        SdlScancodeKpPower = 195,
        SdlScancodeKpPercent = 196,
        SdlScancodeKpLess = 197,
        SdlScancodeKpGreater = 198,
        SdlScancodeKpAmpersand = 199,
        SdlScancodeKpDblampersand = 200,
        SdlScancodeKpVerticalbar = 201,
        SdlScancodeKpDblverticalbar = 202,
        SdlScancodeKpColon = 203,
        SdlScancodeKpHash = 204,
        SdlScancodeKpSpace = 205,
        SdlScancodeKpAt = 206,
        SdlScancodeKpExclam = 207,
        SdlScancodeKpMemstore = 208,
        SdlScancodeKpMemrecall = 209,
        SdlScancodeKpMemclear = 210,
        SdlScancodeKpMemadd = 211,
        SdlScancodeKpMemsubtract = 212,
        SdlScancodeKpMemmultiply = 213,
        SdlScancodeKpMemdivide = 214,
        SdlScancodeKpPlusminus = 215,
        SdlScancodeKpClear = 216,
        SdlScancodeKpClearentry = 217,
        SdlScancodeKpBinary = 218,
        SdlScancodeKpOctal = 219,
        SdlScancodeKpDecimal = 220,
        SdlScancodeKpHexadecimal = 221,

        SdlScancodeLctrl = 224,
        SdlScancodeLshift = 225,
        SdlScancodeLalt = 226,
        SdlScancodeLgui = 227,
        SdlScancodeRctrl = 228,
        SdlScancodeRshift = 229,
        SdlScancodeRalt = 230,
        SdlScancodeRgui = 231,

        SdlScancodeMode = 257,

        /* These come from the USB consumer page (0x0C) */
        SdlScancodeAudionext = 258,
        SdlScancodeAudioprev = 259,
        SdlScancodeAudiostop = 260,
        SdlScancodeAudioplay = 261,
        SdlScancodeAudiomute = 262,
        SdlScancodeMediaselect = 263,
        SdlScancodeWww = 264,
        SdlScancodeMail = 265,
        SdlScancodeCalculator = 266,
        SdlScancodeComputer = 267,
        SdlScancodeAcSearch = 268,
        SdlScancodeAcHome = 269,
        SdlScancodeAcBack = 270,
        SdlScancodeAcForward = 271,
        SdlScancodeAcStop = 272,
        SdlScancodeAcRefresh = 273,
        SdlScancodeAcBookmarks = 274,

        /* These come from other sources, and are mostly mac related */
        SdlScancodeBrightnessdown = 275,
        SdlScancodeBrightnessup = 276,
        SdlScancodeDisplayswitch = 277,
        SdlScancodeKbdillumtoggle = 278,
        SdlScancodeKbdillumdown = 279,
        SdlScancodeKbdillumup = 280,
        SdlScancodeEject = 281,
        SdlScancodeSleep = 282,

        SdlScancodeApp1 = 283,
        SdlScancodeApp2 = 284,

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

        SdlkCapslock = (int) SdlScancode.SdlScancodeCapslock | (1 << 30),

        SdlkF1 = (int) SdlScancode.SdlScancodeF1 | (1 << 30),
        SdlkF2 = (int) SdlScancode.SdlScancodeF2 | (1 << 30),
        SdlkF3 = (int) SdlScancode.SdlScancodeF3 | (1 << 30),
        SdlkF4 = (int) SdlScancode.SdlScancodeF4 | (1 << 30),
        SdlkF5 = (int) SdlScancode.SdlScancodeF5 | (1 << 30),
        SdlkF6 = (int) SdlScancode.SdlScancodeF6 | (1 << 30),
        SdlkF7 = (int) SdlScancode.SdlScancodeF7 | (1 << 30),
        SdlkF8 = (int) SdlScancode.SdlScancodeF8 | (1 << 30),
        SdlkF9 = (int) SdlScancode.SdlScancodeF9 | (1 << 30),
        SdlkF10 = (int) SdlScancode.SdlScancodeF10 | (1 << 30),
        SdlkF11 = (int) SdlScancode.SdlScancodeF11 | (1 << 30),
        SdlkF12 = (int) SdlScancode.SdlScancodeF12 | (1 << 30),

        SdlkPrintscreen = (int) SdlScancode.SdlScancodePrintscreen | (1 << 30),
        SdlkScrolllock = (int) SdlScancode.SdlScancodeScrolllock | (1 << 30),
        SdlkPause = (int) SdlScancode.SdlScancodePause | (1 << 30),
        SdlkInsert = (int) SdlScancode.SdlScancodeInsert | (1 << 30),
        SdlkHome = (int) SdlScancode.SdlScancodeHome | (1 << 30),
        SdlkPageup = (int) SdlScancode.SdlScancodePageup | (1 << 30),
        SdlkDelete = 127,
        SdlkEnd = (int) SdlScancode.SdlScancodeEnd | (1 << 30),
        SdlkPagedown = (int) SdlScancode.SdlScancodePagedown | (1 << 30),
        SdlkRight = (int) SdlScancode.SdlScancodeRight | (1 << 30),
        SdlkLeft = (int) SdlScancode.SdlScancodeLeft | (1 << 30),
        SdlkDown = (int) SdlScancode.SdlScancodeDown | (1 << 30),
        SdlkUp = (int) SdlScancode.SdlScancodeUp | (1 << 30),

        SdlkNumlockclear = (int) SdlScancode.SdlScancodeNumlockclear | (1 << 30),
        SdlkKpDivide = (int) SdlScancode.SdlScancodeKpDivide | (1 << 30),
        SdlkKpMultiply = (int) SdlScancode.SdlScancodeKpMultiply | (1 << 30),
        SdlkKpMinus = (int) SdlScancode.SdlScancodeKpMinus | (1 << 30),
        SdlkKpPlus = (int) SdlScancode.SdlScancodeKpPlus | (1 << 30),
        SdlkKpEnter = (int) SdlScancode.SdlScancodeKpEnter | (1 << 30),
        SdlkKp1 = (int) SdlScancode.SdlScancodeKp1 | (1 << 30),
        SdlkKp2 = (int) SdlScancode.SdlScancodeKp2 | (1 << 30),
        SdlkKp3 = (int) SdlScancode.SdlScancodeKp3 | (1 << 30),
        SdlkKp4 = (int) SdlScancode.SdlScancodeKp4 | (1 << 30),
        SdlkKp5 = (int) SdlScancode.SdlScancodeKp5 | (1 << 30),
        SdlkKp6 = (int) SdlScancode.SdlScancodeKp6 | (1 << 30),
        SdlkKp7 = (int) SdlScancode.SdlScancodeKp7 | (1 << 30),
        SdlkKp8 = (int) SdlScancode.SdlScancodeKp8 | (1 << 30),
        SdlkKp9 = (int) SdlScancode.SdlScancodeKp9 | (1 << 30),
        SdlkKp0 = (int) SdlScancode.SdlScancodeKp0 | (1 << 30),
        SdlkKpPeriod = (int) SdlScancode.SdlScancodeKpPeriod | (1 << 30),

        SdlkApplication = (int) SdlScancode.SdlScancodeApplication | (1 << 30),
        SdlkPower = (int) SdlScancode.SdlScancodePower | (1 << 30),
        SdlkKpEquals = (int) SdlScancode.SdlScancodeKpEquals | (1 << 30),
        SdlkF13 = (int) SdlScancode.SdlScancodeF13 | (1 << 30),
        SdlkF14 = (int) SdlScancode.SdlScancodeF14 | (1 << 30),
        SdlkF15 = (int) SdlScancode.SdlScancodeF15 | (1 << 30),
        SdlkF16 = (int) SdlScancode.SdlScancodeF16 | (1 << 30),
        SdlkF17 = (int) SdlScancode.SdlScancodeF17 | (1 << 30),
        SdlkF18 = (int) SdlScancode.SdlScancodeF18 | (1 << 30),
        SdlkF19 = (int) SdlScancode.SdlScancodeF19 | (1 << 30),
        SdlkF20 = (int) SdlScancode.SdlScancodeF20 | (1 << 30),
        SdlkF21 = (int) SdlScancode.SdlScancodeF21 | (1 << 30),
        SdlkF22 = (int) SdlScancode.SdlScancodeF22 | (1 << 30),
        SdlkF23 = (int) SdlScancode.SdlScancodeF23 | (1 << 30),
        SdlkF24 = (int) SdlScancode.SdlScancodeF24 | (1 << 30),
        SdlkExecute = (int) SdlScancode.SdlScancodeExecute | (1 << 30),
        SdlkHelp = (int) SdlScancode.SdlScancodeHelp | (1 << 30),
        SdlkMenu = (int) SdlScancode.SdlScancodeMenu | (1 << 30),
        SdlkSelect = (int) SdlScancode.SdlScancodeSelect | (1 << 30),
        SdlkStop = (int) SdlScancode.SdlScancodeStop | (1 << 30),
        SdlkAgain = (int) SdlScancode.SdlScancodeAgain | (1 << 30),
        SdlkUndo = (int) SdlScancode.SdlScancodeUndo | (1 << 30),
        SdlkCut = (int) SdlScancode.SdlScancodeCut | (1 << 30),
        SdlkCopy = (int) SdlScancode.SdlScancodeCopy | (1 << 30),
        SdlkPaste = (int) SdlScancode.SdlScancodePaste | (1 << 30),
        SdlkFind = (int) SdlScancode.SdlScancodeFind | (1 << 30),
        SdlkMute = (int) SdlScancode.SdlScancodeMute | (1 << 30),
        SdlkVolumeup = (int) SdlScancode.SdlScancodeVolumeup | (1 << 30),
        SdlkVolumedown = (int) SdlScancode.SdlScancodeVolumedown | (1 << 30),
        SdlkKpComma = (int) SdlScancode.SdlScancodeKpComma | (1 << 30),

        SdlkKpEqualsas400 =
            (int) SdlScancode.SdlScancodeKpEqualsas400 | (1 << 30),

        SdlkAlterase = (int) SdlScancode.SdlScancodeAlterase | (1 << 30),
        SdlkSysreq = (int) SdlScancode.SdlScancodeSysreq | (1 << 30),
        SdlkCancel = (int) SdlScancode.SdlScancodeCancel | (1 << 30),
        SdlkClear = (int) SdlScancode.SdlScancodeClear | (1 << 30),
        SdlkPrior = (int) SdlScancode.SdlScancodePrior | (1 << 30),
        SdlkReturn2 = (int) SdlScancode.SdlScancodeReturn2 | (1 << 30),
        SdlkSeparator = (int) SdlScancode.SdlScancodeSeparator | (1 << 30),
        SdlkOut = (int) SdlScancode.SdlScancodeOut | (1 << 30),
        SdlkOper = (int) SdlScancode.SdlScancodeOper | (1 << 30),
        SdlkClearagain = (int) SdlScancode.SdlScancodeClearagain | (1 << 30),
        SdlkCrsel = (int) SdlScancode.SdlScancodeCrsel | (1 << 30),
        SdlkExsel = (int) SdlScancode.SdlScancodeExsel | (1 << 30),

        SdlkKp00 = (int) SdlScancode.SdlScancodeKp00 | (1 << 30),
        SdlkKp000 = (int) SdlScancode.SdlScancodeKp000 | (1 << 30),

        SdlkThousandsseparator =
            (int) SdlScancode.SdlScancodeThousandsseparator | (1 << 30),

        SdlkDecimalseparator =
            (int) SdlScancode.SdlScancodeDecimalseparator | (1 << 30),
        SdlkCurrencyunit = (int) SdlScancode.SdlScancodeCurrencyunit | (1 << 30),

        SdlkCurrencysubunit =
            (int) SdlScancode.SdlScancodeCurrencysubunit | (1 << 30),
        SdlkKpLeftparen = (int) SdlScancode.SdlScancodeKpLeftparen | (1 << 30),
        SdlkKpRightparen = (int) SdlScancode.SdlScancodeKpRightparen | (1 << 30),
        SdlkKpLeftbrace = (int) SdlScancode.SdlScancodeKpLeftbrace | (1 << 30),
        SdlkKpRightbrace = (int) SdlScancode.SdlScancodeKpRightbrace | (1 << 30),
        SdlkKpTab = (int) SdlScancode.SdlScancodeKpTab | (1 << 30),
        SdlkKpBackspace = (int) SdlScancode.SdlScancodeKpBackspace | (1 << 30),
        SdlkKpA = (int) SdlScancode.SdlScancodeKpA | (1 << 30),
        SdlkKpB = (int) SdlScancode.SdlScancodeKpB | (1 << 30),
        SdlkKpC = (int) SdlScancode.SdlScancodeKpC | (1 << 30),
        SdlkKpD = (int) SdlScancode.SdlScancodeKpD | (1 << 30),
        SdlkKpE = (int) SdlScancode.SdlScancodeKpE | (1 << 30),
        SdlkKpF = (int) SdlScancode.SdlScancodeKpF | (1 << 30),
        SdlkKpXor = (int) SdlScancode.SdlScancodeKpXor | (1 << 30),
        SdlkKpPower = (int) SdlScancode.SdlScancodeKpPower | (1 << 30),
        SdlkKpPercent = (int) SdlScancode.SdlScancodeKpPercent | (1 << 30),
        SdlkKpLess = (int) SdlScancode.SdlScancodeKpLess | (1 << 30),
        SdlkKpGreater = (int) SdlScancode.SdlScancodeKpGreater | (1 << 30),
        SdlkKpAmpersand = (int) SdlScancode.SdlScancodeKpAmpersand | (1 << 30),

        SdlkKpDblampersand =
            (int) SdlScancode.SdlScancodeKpDblampersand | (1 << 30),

        SdlkKpVerticalbar =
            (int) SdlScancode.SdlScancodeKpVerticalbar | (1 << 30),

        SdlkKpDblverticalbar =
            (int) SdlScancode.SdlScancodeKpDblverticalbar | (1 << 30),
        SdlkKpColon = (int) SdlScancode.SdlScancodeKpColon | (1 << 30),
        SdlkKpHash = (int) SdlScancode.SdlScancodeKpHash | (1 << 30),
        SdlkKpSpace = (int) SdlScancode.SdlScancodeKpSpace | (1 << 30),
        SdlkKpAt = (int) SdlScancode.SdlScancodeKpAt | (1 << 30),
        SdlkKpExclam = (int) SdlScancode.SdlScancodeKpExclam | (1 << 30),
        SdlkKpMemstore = (int) SdlScancode.SdlScancodeKpMemstore | (1 << 30),
        SdlkKpMemrecall = (int) SdlScancode.SdlScancodeKpMemrecall | (1 << 30),
        SdlkKpMemclear = (int) SdlScancode.SdlScancodeKpMemclear | (1 << 30),
        SdlkKpMemadd = (int) SdlScancode.SdlScancodeKpMemadd | (1 << 30),

        SdlkKpMemsubtract =
            (int) SdlScancode.SdlScancodeKpMemsubtract | (1 << 30),

        SdlkKpMemmultiply =
            (int) SdlScancode.SdlScancodeKpMemmultiply | (1 << 30),
        SdlkKpMemdivide = (int) SdlScancode.SdlScancodeKpMemdivide | (1 << 30),
        SdlkKpPlusminus = (int) SdlScancode.SdlScancodeKpPlusminus | (1 << 30),
        SdlkKpClear = (int) SdlScancode.SdlScancodeKpClear | (1 << 30),
        SdlkKpClearentry = (int) SdlScancode.SdlScancodeKpClearentry | (1 << 30),
        SdlkKpBinary = (int) SdlScancode.SdlScancodeKpBinary | (1 << 30),
        SdlkKpOctal = (int) SdlScancode.SdlScancodeKpOctal | (1 << 30),
        SdlkKpDecimal = (int) SdlScancode.SdlScancodeKpDecimal | (1 << 30),

        SdlkKpHexadecimal =
            (int) SdlScancode.SdlScancodeKpHexadecimal | (1 << 30),

        SdlkLctrl = (int) SdlScancode.SdlScancodeLctrl | (1 << 30),
        SdlkLshift = (int) SdlScancode.SdlScancodeLshift | (1 << 30),
        SdlkLalt = (int) SdlScancode.SdlScancodeLalt | (1 << 30),
        SdlkLgui = (int) SdlScancode.SdlScancodeLgui | (1 << 30),
        SdlkRctrl = (int) SdlScancode.SdlScancodeRctrl | (1 << 30),
        SdlkRshift = (int) SdlScancode.SdlScancodeRshift | (1 << 30),
        SdlkRalt = (int) SdlScancode.SdlScancodeRalt | (1 << 30),
        SdlkRgui = (int) SdlScancode.SdlScancodeRgui | (1 << 30),

        SdlkMode = (int) SdlScancode.SdlScancodeMode | (1 << 30),

        SdlkAudionext = (int) SdlScancode.SdlScancodeAudionext | (1 << 30),
        SdlkAudioprev = (int) SdlScancode.SdlScancodeAudioprev | (1 << 30),
        SdlkAudiostop = (int) SdlScancode.SdlScancodeAudiostop | (1 << 30),
        SdlkAudioplay = (int) SdlScancode.SdlScancodeAudioplay | (1 << 30),
        SdlkAudiomute = (int) SdlScancode.SdlScancodeAudiomute | (1 << 30),
        SdlkMediaselect = (int) SdlScancode.SdlScancodeMediaselect | (1 << 30),
        SdlkWww = (int) SdlScancode.SdlScancodeWww | (1 << 30),
        SdlkMail = (int) SdlScancode.SdlScancodeMail | (1 << 30),
        SdlkCalculator = (int) SdlScancode.SdlScancodeCalculator | (1 << 30),
        SdlkComputer = (int) SdlScancode.SdlScancodeComputer | (1 << 30),
        SdlkAcSearch = (int) SdlScancode.SdlScancodeAcSearch | (1 << 30),
        SdlkAcHome = (int) SdlScancode.SdlScancodeAcHome | (1 << 30),
        SdlkAcBack = (int) SdlScancode.SdlScancodeAcBack | (1 << 30),
        SdlkAcForward = (int) SdlScancode.SdlScancodeAcForward | (1 << 30),
        SdlkAcStop = (int) SdlScancode.SdlScancodeAcStop | (1 << 30),
        SdlkAcRefresh = (int) SdlScancode.SdlScancodeAcRefresh | (1 << 30),
        SdlkAcBookmarks = (int) SdlScancode.SdlScancodeAcBookmarks | (1 << 30),

        SdlkBrightnessdown =
            (int) SdlScancode.SdlScancodeBrightnessdown | (1 << 30),
        SdlkBrightnessup = (int) SdlScancode.SdlScancodeBrightnessup | (1 << 30),
        SdlkDisplayswitch = (int) SdlScancode.SdlScancodeDisplayswitch | (1 << 30),

        SdlkKbdillumtoggle =
            (int) SdlScancode.SdlScancodeKbdillumtoggle | (1 << 30),
        SdlkKbdillumdown = (int) SdlScancode.SdlScancodeKbdillumdown | (1 << 30),
        SdlkKbdillumup = (int) SdlScancode.SdlScancodeKbdillumup | (1 << 30),
        SdlkEject = (int) SdlScancode.SdlScancodeEject | (1 << 30),
        SdlkSleep = (int) SdlScancode.SdlScancodeSleep | (1 << 30)
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

    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public unsafe class SdlEvent
    {
        [FieldOffset(0)] public uint type;
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
}