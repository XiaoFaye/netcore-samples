using System;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
			Dictionary<int, string> all = new Dictionary<int, string>();

            all.Add(37, "IBM EBCDIC US-Canada (IBM037)");
            all.Add(437, "OEM United States (IBM437)");
            all.Add(500, "IBM EBCDIC International (IBM500)");
            all.Add(708, "Arabic (ASMO 708) (ASMO-708)");
            all.Add(709, "Arabic (ASMO-449+, BCON V4) ()");
            all.Add(710, "Arabic - Transparent Arabic ()");
            all.Add(720, "Arabic (Transparent ASMO); Arabic (DOS) (DOS-720)");
            all.Add(737, "OEM Greek (formerly 437G); Greek (DOS) (ibm737)");
            all.Add(775, "OEM Baltic; Baltic (DOS) (ibm775)");
            all.Add(850, "OEM Multilingual Latin 1; Western European (DOS) (ibm850)");
            all.Add(852, "OEM Latin 2; Central European (DOS) (ibm852)");
            all.Add(855, "OEM Cyrillic (primarily Russian) (IBM855)");
            all.Add(857, "OEM Turkish; Turkish (DOS) (ibm857)");
            all.Add(858, "OEM Multilingual Latin 1 + Euro symbol (IBM00858)");
            all.Add(860, "OEM Portuguese; Portuguese (DOS) (IBM860)");
            all.Add(861, "OEM Icelandic; Icelandic (DOS) (ibm861)");
            all.Add(862, "OEM Hebrew; Hebrew (DOS) (DOS-862)");
            all.Add(863, "OEM French Canadian; French Canadian (DOS) (IBM863)");
            all.Add(864, "OEM Arabic; Arabic (864) (IBM864)");
            all.Add(865, "OEM Nordic; Nordic (DOS) (IBM865)");
            all.Add(866, "OEM Russian; Cyrillic (DOS) (cp866)");
            all.Add(869, "OEM Modern Greek; Greek, Modern (DOS) (ibm869)");
            all.Add(870, "IBM EBCDIC Multilingual/ROECE (Latin 2); IBM EBCDIC Multilingual Latin 2 (IBM870)");
            all.Add(874, "ANSI/OEM Thai (ISO 8859-11); Thai (Windows) (windows-874)");
            all.Add(875, "IBM EBCDIC Greek Modern (cp875)");
            all.Add(932, "ANSI/OEM Japanese; Japanese (Shift-JIS) (shift_jis)");
            all.Add(936, "ANSI/OEM Simplified Chinese (PRC, Singapore); Chinese Simplified (GB2312) (gb2312)");
            all.Add(949, "ANSI/OEM Korean (Unified Hangul Code) (ks_c_5601-1987)");
            all.Add(950, "ANSI/OEM Traditional Chinese (Taiwan; Hong Kong SAR, PRC); Chinese Traditional (Big5) (big5)");
            all.Add(1026, "IBM EBCDIC Turkish (Latin 5) (IBM1026)");
            all.Add(1047, "IBM EBCDIC Latin 1/Open System (IBM01047)");
            all.Add(1140, "IBM EBCDIC US-Canada (037 + Euro symbol); IBM EBCDIC (US-Canada-Euro) (IBM01140)");
            all.Add(1141, "IBM EBCDIC Germany (20273 + Euro symbol); IBM EBCDIC (Germany-Euro) (IBM01141)");
            all.Add(1142, "IBM EBCDIC Denmark-Norway (20277 + Euro symbol); IBM EBCDIC (Denmark-Norway-Euro) (IBM01142)");
            all.Add(1143, "IBM EBCDIC Finland-Sweden (20278 + Euro symbol); IBM EBCDIC (Finland-Sweden-Euro) (IBM01143)");
            all.Add(1144, "IBM EBCDIC Italy (20280 + Euro symbol); IBM EBCDIC (Italy-Euro) (IBM01144)");
            all.Add(1145, "IBM EBCDIC Latin America-Spain (20284 + Euro symbol); IBM EBCDIC (Spain-Euro) (IBM01145)");
            all.Add(1146, "IBM EBCDIC United Kingdom (20285 + Euro symbol); IBM EBCDIC (UK-Euro) (IBM01146)");
            all.Add(1147, "IBM EBCDIC France (20297 + Euro symbol); IBM EBCDIC (France-Euro) (IBM01147)");
            all.Add(1148, "IBM EBCDIC International (500 + Euro symbol); IBM EBCDIC (International-Euro) (IBM01148)");
            all.Add(1149, "IBM EBCDIC Icelandic (20871 + Euro symbol); IBM EBCDIC (Icelandic-Euro) (IBM01149)");
            all.Add(1200, "Unicode UTF-16, little endian byte order (BMP of ISO 10646); available only to managed applications (utf-16)");
            all.Add(1201, "Unicode UTF-16, big endian byte order; available only to managed applications (unicodeFFFE)");
            all.Add(1250, "ANSI Central European; Central European (Windows) (windows-1250)");
            all.Add(1251, "ANSI Cyrillic; Cyrillic (Windows) (windows-1251)");
            all.Add(1252, "ANSI Latin 1; Western European (Windows) (windows-1252)");
            all.Add(1253, "ANSI Greek; Greek (Windows) (windows-1253)");
            all.Add(1254, "ANSI Turkish; Turkish (Windows) (windows-1254)");
            all.Add(1255, "ANSI Hebrew; Hebrew (Windows) (windows-1255)");
            all.Add(1256, "ANSI Arabic; Arabic (Windows) (windows-1256)");
            all.Add(1257, "ANSI Baltic; Baltic (Windows) (windows-1257)");
            all.Add(1258, "ANSI/OEM Vietnamese; Vietnamese (Windows) (windows-1258)");
            all.Add(1361, "Korean (Johab) (Johab)");
            all.Add(10000, "MAC Roman; Western European (Mac) (macintosh)");
            all.Add(10001, "Japanese (Mac) (x-mac-japanese)");
            all.Add(10002, "MAC Traditional Chinese (Big5); Chinese Traditional (Mac) (x-mac-chinesetrad)");
            all.Add(10003, "Korean (Mac) (x-mac-korean)");
            all.Add(10004, "Arabic (Mac) (x-mac-arabic)");
            all.Add(10005, "Hebrew (Mac) (x-mac-hebrew)");
            all.Add(10006, "Greek (Mac) (x-mac-greek)");
            all.Add(10007, "Cyrillic (Mac) (x-mac-cyrillic)");
            all.Add(10008, "MAC Simplified Chinese (GB 2312); Chinese Simplified (Mac) (x-mac-chinesesimp)");
            all.Add(10010, "Romanian (Mac) (x-mac-romanian)");
            all.Add(10017, "Ukrainian (Mac) (x-mac-ukrainian)");
            all.Add(10021, "Thai (Mac) (x-mac-thai)");
            all.Add(10029, "MAC Latin 2; Central European (Mac) (x-mac-ce)");
            all.Add(10079, "Icelandic (Mac) (x-mac-icelandic)");
            all.Add(10081, "Turkish (Mac) (x-mac-turkish)");
            all.Add(10082, "Croatian (Mac) (x-mac-croatian)");
            all.Add(12000, "Unicode UTF-32, little endian byte order; available only to managed applications (utf-32)");
            all.Add(12001, "Unicode UTF-32, big endian byte order; available only to managed applications (utf-32BE)");
            all.Add(20000, "CNS Taiwan; Chinese Traditional (CNS) (x-Chinese_CNS)");
            all.Add(20001, "TCA Taiwan (x-cp20001)");
            all.Add(20002, "Eten Taiwan; Chinese Traditional (Eten) (x_Chinese-Eten)");
            all.Add(20003, "IBM5550 Taiwan (x-cp20003)");
            all.Add(20004, "TeleText Taiwan (x-cp20004)");
            all.Add(20005, "Wang Taiwan (x-cp20005)");
            all.Add(20105, "IA5 (IRV International Alphabet No. 5, 7-bit); Western European (IA5) (x-IA5)");
            all.Add(20106, "IA5 German (7-bit) (x-IA5-German)");
            all.Add(20107, "IA5 Swedish (7-bit) (x-IA5-Swedish)");
            all.Add(20108, "IA5 Norwegian (7-bit) (x-IA5-Norwegian)");
            all.Add(20127, "US-ASCII (7-bit) (us-ascii)");
            all.Add(20261, "T.61 (x-cp20261)");
            all.Add(20269, "ISO 6937 Non-Spacing Accent (x-cp20269)");
            all.Add(20273, "IBM EBCDIC Germany (IBM273)");
            all.Add(20277, "IBM EBCDIC Denmark-Norway (IBM277)");
            all.Add(20278, "IBM EBCDIC Finland-Sweden (IBM278)");
            all.Add(20280, "IBM EBCDIC Italy (IBM280)");
            all.Add(20284, "IBM EBCDIC Latin America-Spain (IBM284)");
            all.Add(20285, "IBM EBCDIC United Kingdom (IBM285)");
            all.Add(20290, "IBM EBCDIC Japanese Katakana Extended (IBM290)");
            all.Add(20297, "IBM EBCDIC France (IBM297)");
            all.Add(20420, "IBM EBCDIC Arabic (IBM420)");
            all.Add(20423, "IBM EBCDIC Greek (IBM423)");
            all.Add(20424, "IBM EBCDIC Hebrew (IBM424)");
            all.Add(20833, "IBM EBCDIC Korean Extended (x-EBCDIC-KoreanExtended)");
            all.Add(20838, "IBM EBCDIC Thai (IBM-Thai)");
            all.Add(20866, "Russian (KOI8-R); Cyrillic (KOI8-R) (koi8-r)");
            all.Add(20871, "IBM EBCDIC Icelandic (IBM871)");
            all.Add(20880, "IBM EBCDIC Cyrillic Russian (IBM880)");
            all.Add(20905, "IBM EBCDIC Turkish (IBM905)");
            all.Add(20924, "IBM EBCDIC Latin 1/Open System (1047 + Euro symbol) (IBM00924)");
            all.Add(20932, "Japanese (JIS 0208-1990 and 0212-1990) (EUC-JP)");
            all.Add(20936, "Simplified Chinese (GB2312); Chinese Simplified (GB2312-80) (x-cp20936)");
            all.Add(20949, "Korean Wansung (x-cp20949)");
            all.Add(21025, "IBM EBCDIC Cyrillic Serbian-Bulgarian (cp1025)");
            all.Add(21866, "Ukrainian (KOI8-U); Cyrillic (KOI8-U) (koi8-u)");
            all.Add(28591, "ISO 8859-1 Latin 1; Western European (ISO) (iso-8859-1)");
            all.Add(28592, "ISO 8859-2 Central European; Central European (ISO) (iso-8859-2)");
            all.Add(28593, "ISO 8859-3 Latin 3 (iso-8859-3)");
            all.Add(28594, "ISO 8859-4 Baltic (iso-8859-4)");
            all.Add(28595, "ISO 8859-5 Cyrillic (iso-8859-5)");
            all.Add(28596, "ISO 8859-6 Arabic (iso-8859-6)");
            all.Add(28597, "ISO 8859-7 Greek (iso-8859-7)");
            all.Add(28598, "ISO 8859-8 Hebrew; Hebrew (ISO-Visual) (iso-8859-8)");
            all.Add(28599, "ISO 8859-9 Turkish (iso-8859-9)");
            all.Add(28603, "ISO 8859-13 Estonian (iso-8859-13)");
            all.Add(28605, "ISO 8859-15 Latin 9 (iso-8859-15)");
            all.Add(29001, "Europa 3 (x-Europa)");
            all.Add(38598, "ISO 8859-8 Hebrew; Hebrew (ISO-Logical) (iso-8859-8-i)");
            all.Add(50220, "ISO 2022 Japanese with no halfwidth Katakana; Japanese (JIS) (iso-2022-jp)");
            all.Add(50221, "ISO 2022 Japanese with halfwidth Katakana; Japanese (JIS-Allow 1 byte Kana) (csISO2022JP)");
            all.Add(50222, "ISO 2022 Japanese JIS X 0201-1989; Japanese (JIS-Allow 1 byte Kana - SO/SI) (iso-2022-jp)");
            all.Add(50225, "ISO 2022 Korean (iso-2022-kr)");
            all.Add(50227, "ISO 2022 Simplified Chinese; Chinese Simplified (ISO 2022) (x-cp50227)");
            all.Add(50229, "ISO 2022 Traditional Chinese ()");
            all.Add(50930, "EBCDIC Japanese (Katakana) Extended ()");
            all.Add(50931, "EBCDIC US-Canada and Japanese ()");
            all.Add(50933, "EBCDIC Korean Extended and Korean ()");
            all.Add(50935, "EBCDIC Simplified Chinese Extended and Simplified Chinese ()");
            all.Add(50936, "EBCDIC Simplified Chinese ()");
            all.Add(50937, "EBCDIC US-Canada and Traditional Chinese ()");
            all.Add(50939, "EBCDIC Japanese (Latin) Extended and Japanese ()");
            all.Add(51932, "EUC Japanese (euc-jp)");
            all.Add(51936, "EUC Simplified Chinese; Chinese Simplified (EUC) (EUC-CN)");
            all.Add(51949, "EUC Korean (euc-kr)");
            all.Add(51950, "EUC Traditional Chinese ()");
            all.Add(52936, "HZ-GB2312 Simplified Chinese; Chinese Simplified (HZ) (hz-gb-2312)");
            all.Add(54936, "Windows XP and later: GB18030 Simplified Chinese (4 byte); Chinese Simplified (GB18030) (GB18030)");
            all.Add(57002, "ISCII Devanagari (x-iscii-de)");
            all.Add(57003, "ISCII Bangla (x-iscii-be)");
            all.Add(57004, "ISCII Tamil (x-iscii-ta)");
            all.Add(57005, "ISCII Telugu (x-iscii-te)");
            all.Add(57006, "ISCII Assamese (x-iscii-as)");
            all.Add(57007, "ISCII Odia (x-iscii-or)");
            all.Add(57008, "ISCII Kannada (x-iscii-ka)");
            all.Add(57009, "ISCII Malayalam (x-iscii-ma)");
            all.Add(57010, "ISCII Gujarati (x-iscii-gu)");
            all.Add(57011, "ISCII Punjabi (x-iscii-pa)");
            all.Add(65000, "Unicode (UTF-7) (utf-7)");
            all.Add(65001, "Unicode (UTF-8) (utf-8)");
			
			
			Console.WriteLine("Encoding support by default:");
			Console.WriteLine("----------------------------");
			
			foreach(var eco in all)
			{
				try
				{
					Encoding.GetEncoding(eco.Key);
					Console.WriteLine(eco.Value + ": Supported");
				}
				catch(NotSupportedException ex)
				{
					Console.WriteLine(eco.Value + ": Not Supported");
				}
			}
			
			Console.WriteLine("*******************************************************************");
			
			Console.WriteLine("Encoding support with CodePageEncodingProvider:");
			Console.WriteLine("-----------------------------------------------");
						
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
			foreach(var eco in all)
			{
				try
				{
					Encoding.GetEncoding(eco.Key);
					Console.WriteLine(eco.Value + ": Supported");
				}
				catch(NotSupportedException ex)
				{
					Console.WriteLine(eco.Value + ": Not Supported");
				}
			}
			
        }
    }
}
