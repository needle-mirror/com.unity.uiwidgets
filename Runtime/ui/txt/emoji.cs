using System;
using System.Collections.Generic;
using Unity.UIWidgets.foundation;
using UnityEngine;

namespace Unity.UIWidgets.ui {
    public class EmojiUtils {
        static Image _image;

        public static Image image {
            get {
                if (_image == null || _image.texture == null) {
                    try {
                        _image = new Image(
                            Resources.Load<Texture2D>("Emoji")
                        );
                    }
                    catch (Exception e) {
                        _image = null;
                        Debug.LogError(e.StackTrace);
                    }
                }

                return _image;
            }
        }

        public static readonly Dictionary<int, int> emojiLookupTable = new Dictionary<int, int> {
            {0x1f004, 0}, {0x1f0cf, 1}, {0x1f170, 2}, {0x1f171, 3}, {0x1f17e, 4}, {0x1f17f, 5}, {0x1f18e, 6},
            {0x1f191, 7}, {0x1f192, 8}, {0x1f193, 9}, {0x1f194, 10}, {0x1f195, 11}, {0x1f196, 12}, {0x1f197, 13},
            {0x1f198, 14}, {0x1f199, 15}, {0x1f19a, 16}, {0x1f1e6, 17}, {0x1f1e7, 18}, {0x1f1e8, 19}, {0x1f1e9, 20},
            {0x1f1ea, 21}, {0x1f1eb, 22}, {0x1f1ec, 23}, {0x1f1ed, 24}, {0x1f1ee, 25}, {0x1f1ef, 26}, {0x1f1f0, 27},
            {0x1f1f1, 28}, {0x1f1f2, 29}, {0x1f1f3, 30}, {0x1f1f4, 31}, {0x1f1f5, 32}, {0x1f1f6, 33}, {0x1f1f7, 34},
            {0x1f1f8, 35}, {0x1f1f9, 36}, {0x1f1fa, 37}, {0x1f1fb, 38}, {0x1f1fc, 39}, {0x1f1fd, 40}, {0x1f1fe, 41},
            {0x1f1ff, 42}, {0x1f201, 43}, {0x1f202, 44}, {0x1f21a, 45}, {0x1f22f, 46}, {0x1f232, 47}, {0x1f233, 48},
            {0x1f234, 49}, {0x1f235, 50}, {0x1f236, 51}, {0x1f237, 52}, {0x1f238, 53}, {0x1f239, 54}, {0x1f23a, 55},
            {0x1f250, 56}, {0x1f251, 57}, {0x1f300, 58}, {0x1f301, 59}, {0x1f302, 60}, {0x1f303, 61}, {0x1f304, 62},
            {0x1f305, 63}, {0x1f306, 64}, {0x1f307, 65}, {0x1f308, 66}, {0x1f309, 67}, {0x1f30a, 68}, {0x1f30b, 69},
            {0x1f30c, 70}, {0x1f30d, 71}, {0x1f30e, 72}, {0x1f30f, 73}, {0x1f310, 74}, {0x1f311, 75}, {0x1f312, 76},
            {0x1f313, 77}, {0x1f314, 78}, {0x1f315, 79}, {0x1f316, 80}, {0x1f317, 81}, {0x1f318, 82}, {0x1f319, 83},
            {0x1f31a, 84}, {0x1f31b, 85}, {0x1f31c, 86}, {0x1f31d, 87}, {0x1f31e, 88}, {0x1f31f, 89}, {0x1f320, 90},
            {0x1f321, 91}, {0x1f324, 92}, {0x1f325, 93}, {0x1f326, 94}, {0x1f327, 95}, {0x1f328, 96}, {0x1f329, 97},
            {0x1f32a, 98}, {0x1f32b, 99}, {0x1f32c, 100}, {0x1f32d, 101}, {0x1f32e, 102}, {0x1f32f, 103}, {0x1f330, 104},
            {0x1f331, 105}, {0x1f332, 106}, {0x1f333, 107}, {0x1f334, 108}, {0x1f335, 109}, {0x1f336, 110}, {0x1f337, 111},
            {0x1f338, 112}, {0x1f339, 113}, {0x1f33a, 114}, {0x1f33b, 115}, {0x1f33c, 116}, {0x1f33d, 117}, {0x1f33e, 118},
            {0x1f33f, 119}, {0x1f340, 120}, {0x1f341, 121}, {0x1f342, 122}, {0x1f343, 123}, {0x1f344, 124}, {0x1f345, 125},
            {0x1f346, 126}, {0x1f347, 127}, {0x1f348, 128}, {0x1f349, 129}, {0x1f34a, 130}, {0x1f34b, 131}, {0x1f34c, 132},
            {0x1f34d, 133}, {0x1f34e, 134}, {0x1f34f, 135}, {0x1f350, 136}, {0x1f351, 137}, {0x1f352, 138}, {0x1f353, 139},
            {0x1f354, 140}, {0x1f355, 141}, {0x1f356, 142}, {0x1f357, 143}, {0x1f358, 144}, {0x1f359, 145}, {0x1f35a, 146},
            {0x1f35b, 147}, {0x1f35c, 148}, {0x1f35d, 149}, {0x1f35e, 150}, {0x1f35f, 151}, {0x1f360, 152}, {0x1f361, 153},
            {0x1f362, 154}, {0x1f363, 155}, {0x1f364, 156}, {0x1f365, 157}, {0x1f366, 158}, {0x1f367, 159}, {0x1f368, 160},
            {0x1f369, 161}, {0x1f36a, 162}, {0x1f36b, 163}, {0x1f36c, 164}, {0x1f36d, 165}, {0x1f36e, 166}, {0x1f36f, 167},
            {0x1f370, 168}, {0x1f371, 169}, {0x1f372, 170}, {0x1f373, 171}, {0x1f374, 172}, {0x1f375, 173}, {0x1f376, 174},
            {0x1f377, 175}, {0x1f378, 176}, {0x1f379, 177}, {0x1f37a, 178}, {0x1f37b, 179}, {0x1f37c, 180}, {0x1f37d, 181},
            {0x1f37e, 182}, {0x1f37f, 183}, {0x1f380, 184}, {0x1f381, 185}, {0x1f382, 186}, {0x1f383, 187}, {0x1f384, 188},
            {0x1f385, 189}, {0x1f386, 190}, {0x1f387, 191}, {0x1f388, 192}, {0x1f389, 193}, {0x1f38a, 194}, {0x1f38b, 195},
            {0x1f38c, 196}, {0x1f38d, 197}, {0x1f38e, 198}, {0x1f38f, 199}, {0x1f390, 200}, {0x1f391, 201}, {0x1f392, 202},
            {0x1f393, 203}, {0x1f396, 204}, {0x1f397, 205}, {0x1f399, 206}, {0x1f39a, 207}, {0x1f39b, 208}, {0x1f39e, 209},
            {0x1f39f, 210}, {0x1f3a0, 211}, {0x1f3a1, 212}, {0x1f3a2, 213}, {0x1f3a3, 214}, {0x1f3a4, 215}, {0x1f3a5, 216},
            {0x1f3a6, 217}, {0x1f3a7, 218}, {0x1f3a8, 219}, {0x1f3a9, 220}, {0x1f3aa, 221}, {0x1f3ab, 222}, {0x1f3ac, 223},
            {0x1f3ad, 224}, {0x1f3ae, 225}, {0x1f3af, 226}, {0x1f3b0, 227}, {0x1f3b1, 228}, {0x1f3b2, 229}, {0x1f3b3, 230},
            {0x1f3b4, 231}, {0x1f3b5, 232}, {0x1f3b6, 233}, {0x1f3b7, 234}, {0x1f3b8, 235}, {0x1f3b9, 236}, {0x1f3ba, 237},
            {0x1f3bb, 238}, {0x1f3bc, 239}, {0x1f3bd, 240}, {0x1f3be, 241}, {0x1f3bf, 242}, {0x1f3c0, 243}, {0x1f3c1, 244},
            {0x1f3c2, 245}, {0x1f3c3, 246}, {0x1f3c4, 247}, {0x1f3c5, 248}, {0x1f3c6, 249}, {0x1f3c7, 250}, {0x1f3c8, 251},
            {0x1f3c9, 252}, {0x1f3ca, 253}, {0x1f3cb, 254}, {0x1f3cc, 255}, {0x1f3cd, 256}, {0x1f3ce, 257}, {0x1f3cf, 258},
            {0x1f3d0, 259}, {0x1f3d1, 260}, {0x1f3d2, 261}, {0x1f3d3, 262}, {0x1f3d4, 263}, {0x1f3d5, 264}, {0x1f3d6, 265},
            {0x1f3d7, 266}, {0x1f3d8, 267}, {0x1f3d9, 268}, {0x1f3da, 269}, {0x1f3db, 270}, {0x1f3dc, 271}, {0x1f3dd, 272},
            {0x1f3de, 273}, {0x1f3df, 274}, {0x1f3e0, 275}, {0x1f3e1, 276}, {0x1f3e2, 277}, {0x1f3e3, 278}, {0x1f3e4, 279},
            {0x1f3e5, 280}, {0x1f3e6, 281}, {0x1f3e7, 282}, {0x1f3e8, 283}, {0x1f3e9, 284}, {0x1f3ea, 285}, {0x1f3eb, 286},
            {0x1f3ec, 287}, {0x1f3ed, 288}, {0x1f3ee, 289}, {0x1f3ef, 290}, {0x1f3f0, 291}, {0x1f3f3, 292}, {0x1f3f4, 293},
            {0x1f3f5, 294}, {0x1f3f7, 295}, {0x1f3f8, 296}, {0x1f3f9, 297}, {0x1f3fa, 298}, {0x1f3fb, 299}, {0x1f3fc, 300},
            {0x1f3fd, 301}, {0x1f3fe, 302}, {0x1f3ff, 303}, {0x1f400, 304}, {0x1f401, 305}, {0x1f402, 306}, {0x1f403, 307},
            {0x1f404, 308}, {0x1f405, 309}, {0x1f406, 310}, {0x1f407, 311}, {0x1f408, 312}, {0x1f409, 313}, {0x1f40a, 314},
            {0x1f40b, 315}, {0x1f40c, 316}, {0x1f40d, 317}, {0x1f40e, 318}, {0x1f40f, 319}, {0x1f410, 320}, {0x1f411, 321},
            {0x1f412, 322}, {0x1f413, 323}, {0x1f414, 324}, {0x1f415, 325}, {0x1f416, 326}, {0x1f417, 327}, {0x1f418, 328},
            {0x1f419, 329}, {0x1f41a, 330}, {0x1f41b, 331}, {0x1f41c, 332}, {0x1f41d, 333}, {0x1f41e, 334}, {0x1f41f, 335},
            {0x1f420, 336}, {0x1f421, 337}, {0x1f422, 338}, {0x1f423, 339}, {0x1f424, 340}, {0x1f425, 341}, {0x1f426, 342},
            {0x1f427, 343}, {0x1f428, 344}, {0x1f429, 345}, {0x1f42a, 346}, {0x1f42b, 347}, {0x1f42c, 348}, {0x1f42d, 349},
            {0x1f42e, 350}, {0x1f42f, 351}, {0x1f430, 352}, {0x1f431, 353}, {0x1f432, 354}, {0x1f433, 355}, {0x1f434, 356},
            {0x1f435, 357}, {0x1f436, 358}, {0x1f437, 359}, {0x1f438, 360}, {0x1f439, 361}, {0x1f43a, 362}, {0x1f43b, 363},
            {0x1f43c, 364}, {0x1f43d, 365}, {0x1f43e, 366}, {0x1f43f, 367}, {0x1f440, 368}, {0x1f441, 369}, {0x1f442, 370},
            {0x1f443, 371}, {0x1f444, 372}, {0x1f445, 373}, {0x1f446, 374}, {0x1f447, 375}, {0x1f448, 376}, {0x1f449, 377},
            {0x1f44a, 378}, {0x1f44b, 379}, {0x1f44c, 380}, {0x1f44d, 381}, {0x1f44e, 382}, {0x1f44f, 383}, {0x1f450, 384},
            {0x1f451, 385}, {0x1f452, 386}, {0x1f453, 387}, {0x1f454, 388}, {0x1f455, 389}, {0x1f456, 390}, {0x1f457, 391},
            {0x1f458, 392}, {0x1f459, 393}, {0x1f45a, 394}, {0x1f45b, 395}, {0x1f45c, 396}, {0x1f45d, 397}, {0x1f45e, 398},
            {0x1f45f, 399}, {0x1f460, 400}, {0x1f461, 401}, {0x1f462, 402}, {0x1f463, 403}, {0x1f464, 404}, {0x1f465, 405},
            {0x1f466, 406}, {0x1f467, 407}, {0x1f468, 408}, {0x1f469, 409}, {0x1f46a, 410}, {0x1f46b, 411}, {0x1f46c, 412},
            {0x1f46d, 413}, {0x1f46e, 414}, {0x1f46f, 415}, {0x1f470, 416}, {0x1f471, 417}, {0x1f472, 418}, {0x1f473, 419},
            {0x1f474, 420}, {0x1f475, 421}, {0x1f476, 422}, {0x1f477, 423}, {0x1f478, 424}, {0x1f479, 425}, {0x1f47a, 426},
            {0x1f47b, 427}, {0x1f47c, 428}, {0x1f47d, 429}, {0x1f47e, 430}, {0x1f47f, 431}, {0x1f480, 432}, {0x1f481, 433},
            {0x1f482, 434}, {0x1f483, 435}, {0x1f484, 436}, {0x1f485, 437}, {0x1f486, 438}, {0x1f487, 439}, {0x1f488, 440},
            {0x1f489, 441}, {0x1f48a, 442}, {0x1f48b, 443}, {0x1f48c, 444}, {0x1f48d, 445}, {0x1f48e, 446}, {0x1f48f, 447},
            {0x1f490, 448}, {0x1f491, 449}, {0x1f492, 450}, {0x1f493, 451}, {0x1f494, 452}, {0x1f495, 453}, {0x1f496, 454},
            {0x1f497, 455}, {0x1f498, 456}, {0x1f499, 457}, {0x1f49a, 458}, {0x1f49b, 459}, {0x1f49c, 460}, {0x1f49d, 461},
            {0x1f49e, 462}, {0x1f49f, 463}, {0x1f4a0, 464}, {0x1f4a1, 465}, {0x1f4a2, 466}, {0x1f4a3, 467}, {0x1f4a4, 468},
            {0x1f4a5, 469}, {0x1f4a6, 470}, {0x1f4a7, 471}, {0x1f4a8, 472}, {0x1f4a9, 473}, {0x1f4aa, 474}, {0x1f4ab, 475},
            {0x1f4ac, 476}, {0x1f4ad, 477}, {0x1f4ae, 478}, {0x1f4af, 479}, {0x1f4b0, 480}, {0x1f4b1, 481}, {0x1f4b2, 482},
            {0x1f4b3, 483}, {0x1f4b4, 484}, {0x1f4b5, 485}, {0x1f4b6, 486}, {0x1f4b7, 487}, {0x1f4b8, 488}, {0x1f4b9, 489},
            {0x1f4ba, 490}, {0x1f4bb, 491}, {0x1f4bc, 492}, {0x1f4bd, 493}, {0x1f4be, 494}, {0x1f4bf, 495}, {0x1f4c0, 496},
            {0x1f4c1, 497}, {0x1f4c2, 498}, {0x1f4c3, 499}, {0x1f4c4, 500}, {0x1f4c5, 501}, {0x1f4c6, 502}, {0x1f4c7, 503},
            {0x1f4c8, 504}, {0x1f4c9, 505}, {0x1f4ca, 506}, {0x1f4cb, 507}, {0x1f4cc, 508}, {0x1f4cd, 509}, {0x1f4ce, 510},
            {0x1f4cf, 511}, {0x1f4d0, 512}, {0x1f4d1, 513}, {0x1f4d2, 514}, {0x1f4d3, 515}, {0x1f4d4, 516}, {0x1f4d5, 517},
            {0x1f4d6, 518}, {0x1f4d7, 519}, {0x1f4d8, 520}, {0x1f4d9, 521}, {0x1f4da, 522}, {0x1f4db, 523}, {0x1f4dc, 524},
            {0x1f4dd, 525}, {0x1f4de, 526}, {0x1f4df, 527}, {0x1f4e0, 528}, {0x1f4e1, 529}, {0x1f4e2, 530}, {0x1f4e3, 531},
            {0x1f4e4, 532}, {0x1f4e5, 533}, {0x1f4e6, 534}, {0x1f4e7, 535}, {0x1f4e8, 536}, {0x1f4e9, 537}, {0x1f4ea, 538},
            {0x1f4eb, 539}, {0x1f4ec, 540}, {0x1f4ed, 541}, {0x1f4ee, 542}, {0x1f4ef, 543}, {0x1f4f0, 544}, {0x1f4f1, 545},
            {0x1f4f2, 546}, {0x1f4f3, 547}, {0x1f4f4, 548}, {0x1f4f5, 549}, {0x1f4f6, 550}, {0x1f4f7, 551}, {0x1f4f8, 552},
            {0x1f4f9, 553}, {0x1f4fa, 554}, {0x1f4fb, 555}, {0x1f4fc, 556}, {0x1f4fd, 557}, {0x1f4ff, 558}, {0x1f500, 559},
            {0x1f501, 560}, {0x1f502, 561}, {0x1f503, 562}, {0x1f504, 563}, {0x1f505, 564}, {0x1f506, 565}, {0x1f507, 566},
            {0x1f508, 567}, {0x1f509, 568}, {0x1f50a, 569}, {0x1f50b, 570}, {0x1f50c, 571}, {0x1f50d, 572}, {0x1f50e, 573},
            {0x1f50f, 574}, {0x1f510, 575}, {0x1f511, 576}, {0x1f512, 577}, {0x1f513, 578}, {0x1f514, 579}, {0x1f515, 580},
            {0x1f516, 581}, {0x1f517, 582}, {0x1f518, 583}, {0x1f519, 584}, {0x1f51a, 585}, {0x1f51b, 586}, {0x1f51c, 587},
            {0x1f51d, 588}, {0x1f51e, 589}, {0x1f51f, 590}, {0x1f520, 591}, {0x1f521, 592}, {0x1f522, 593}, {0x1f523, 594},
            {0x1f524, 595}, {0x1f525, 596}, {0x1f526, 597}, {0x1f527, 598}, {0x1f528, 599}, {0x1f529, 600}, {0x1f52a, 601},
            {0x1f52b, 602}, {0x1f52c, 603}, {0x1f52d, 604}, {0x1f52e, 605}, {0x1f52f, 606}, {0x1f530, 607}, {0x1f531, 608},
            {0x1f532, 609}, {0x1f533, 610}, {0x1f534, 611}, {0x1f535, 612}, {0x1f536, 613}, {0x1f537, 614}, {0x1f538, 615},
            {0x1f539, 616}, {0x1f53a, 617}, {0x1f53b, 618}, {0x1f53c, 619}, {0x1f53d, 620}, {0x1f549, 621}, {0x1f54a, 622},
            {0x1f54b, 623}, {0x1f54c, 624}, {0x1f54d, 625}, {0x1f54e, 626}, {0x1f550, 627}, {0x1f551, 628}, {0x1f552, 629},
            {0x1f553, 630}, {0x1f554, 631}, {0x1f555, 632}, {0x1f556, 633}, {0x1f557, 634}, {0x1f558, 635}, {0x1f559, 636},
            {0x1f55a, 637}, {0x1f55b, 638}, {0x1f55c, 639}, {0x1f55d, 640}, {0x1f55e, 641}, {0x1f55f, 642}, {0x1f560, 643},
            {0x1f561, 644}, {0x1f562, 645}, {0x1f563, 646}, {0x1f564, 647}, {0x1f565, 648}, {0x1f566, 649}, {0x1f567, 650},
            {0x1f56f, 651}, {0x1f570, 652}, {0x1f573, 653}, {0x1f574, 654}, {0x1f575, 655}, {0x1f576, 656}, {0x1f577, 657},
            {0x1f578, 658}, {0x1f579, 659}, {0x1f57a, 660}, {0x1f587, 661}, {0x1f58a, 662}, {0x1f58b, 663}, {0x1f58c, 664},
            {0x1f58d, 665}, {0x1f590, 666}, {0x1f595, 667}, {0x1f596, 668}, {0x1f5a4, 669}, {0x1f5a5, 670}, {0x1f5a8, 671},
            {0x1f5b1, 672}, {0x1f5b2, 673}, {0x1f5bc, 674}, {0x1f5c2, 675}, {0x1f5c3, 676}, {0x1f5c4, 677}, {0x1f5d1, 678},
            {0x1f5d2, 679}, {0x1f5d3, 680}, {0x1f5dc, 681}, {0x1f5dd, 682}, {0x1f5de, 683}, {0x1f5e1, 684}, {0x1f5e3, 685},
            {0x1f5e8, 686}, {0x1f5ef, 687}, {0x1f5f3, 688}, {0x1f5fa, 689}, {0x1f5fb, 690}, {0x1f5fc, 691}, {0x1f5fd, 692},
            {0x1f5fe, 693}, {0x1f5ff, 694}, {0x1f600, 695}, {0x1f601, 696}, {0x1f602, 697}, {0x1f603, 698}, {0x1f604, 699},
            {0x1f605, 700}, {0x1f606, 701}, {0x1f607, 702}, {0x1f608, 703}, {0x1f609, 704}, {0x1f60a, 705}, {0x1f60b, 706},
            {0x1f60c, 707}, {0x1f60d, 708}, {0x1f60e, 709}, {0x1f60f, 710}, {0x1f610, 711}, {0x1f611, 712}, {0x1f612, 713},
            {0x1f613, 714}, {0x1f614, 715}, {0x1f615, 716}, {0x1f616, 717}, {0x1f617, 718}, {0x1f618, 719}, {0x1f619, 720},
            {0x1f61a, 721}, {0x1f61b, 722}, {0x1f61c, 723}, {0x1f61d, 724}, {0x1f61e, 725}, {0x1f61f, 726}, {0x1f620, 727},
            {0x1f621, 728}, {0x1f622, 729}, {0x1f623, 730}, {0x1f624, 731}, {0x1f625, 732}, {0x1f626, 733}, {0x1f627, 734},
            {0x1f628, 735}, {0x1f629, 736}, {0x1f62a, 737}, {0x1f62b, 738}, {0x1f62c, 739}, {0x1f62d, 740}, {0x1f62e, 741},
            {0x1f62f, 742}, {0x1f630, 743}, {0x1f631, 744}, {0x1f632, 745}, {0x1f633, 746}, {0x1f634, 747}, {0x1f635, 748},
            {0x1f636, 749}, {0x1f637, 750}, {0x1f638, 751}, {0x1f639, 752}, {0x1f63a, 753}, {0x1f63b, 754}, {0x1f63c, 755},
            {0x1f63d, 756}, {0x1f63e, 757}, {0x1f63f, 758}, {0x1f640, 759}, {0x1f641, 760}, {0x1f642, 761}, {0x1f643, 762},
            {0x1f644, 763}, {0x1f645, 764}, {0x1f646, 765}, {0x1f647, 766}, {0x1f648, 767}, {0x1f649, 768}, {0x1f64a, 769},
            {0x1f64b, 770}, {0x1f64c, 771}, {0x1f64d, 772}, {0x1f64e, 773}, {0x1f64f, 774}, {0x1f680, 775}, {0x1f681, 776},
            {0x1f682, 777}, {0x1f683, 778}, {0x1f684, 779}, {0x1f685, 780}, {0x1f686, 781}, {0x1f687, 782}, {0x1f688, 783},
            {0x1f689, 784}, {0x1f68a, 785}, {0x1f68b, 786}, {0x1f68c, 787}, {0x1f68d, 788}, {0x1f68e, 789}, {0x1f68f, 790},
            {0x1f690, 791}, {0x1f691, 792}, {0x1f692, 793}, {0x1f693, 794}, {0x1f694, 795}, {0x1f695, 796}, {0x1f696, 797},
            {0x1f697, 798}, {0x1f698, 799}, {0x1f699, 800}, {0x1f69a, 801}, {0x1f69b, 802}, {0x1f69c, 803}, {0x1f69d, 804},
            {0x1f69e, 805}, {0x1f69f, 806}, {0x1f6a0, 807}, {0x1f6a1, 808}, {0x1f6a2, 809}, {0x1f6a3, 810}, {0x1f6a4, 811},
            {0x1f6a5, 812}, {0x1f6a6, 813}, {0x1f6a7, 814}, {0x1f6a8, 815}, {0x1f6a9, 816}, {0x1f6aa, 817}, {0x1f6ab, 818},
            {0x1f6ac, 819}, {0x1f6ad, 820}, {0x1f6ae, 821}, {0x1f6af, 822}, {0x1f6b0, 823}, {0x1f6b1, 824}, {0x1f6b2, 825},
            {0x1f6b3, 826}, {0x1f6b4, 827}, {0x1f6b5, 828}, {0x1f6b6, 829}, {0x1f6b7, 830}, {0x1f6b8, 831}, {0x1f6b9, 832},
            {0x1f6ba, 833}, {0x1f6bb, 834}, {0x1f6bc, 835}, {0x1f6bd, 836}, {0x1f6be, 837}, {0x1f6bf, 838}, {0x1f6c0, 839},
            {0x1f6c1, 840}, {0x1f6c2, 841}, {0x1f6c3, 842}, {0x1f6c4, 843}, {0x1f6c5, 844}, {0x1f6cb, 845}, {0x1f6cc, 846},
            {0x1f6cd, 847}, {0x1f6ce, 848}, {0x1f6cf, 849}, {0x1f6d0, 850}, {0x1f6d1, 851}, {0x1f6d2, 852}, {0x1f6d5, 853},
            {0x1f6e0, 854}, {0x1f6e1, 855}, {0x1f6e2, 856}, {0x1f6e3, 857}, {0x1f6e4, 858}, {0x1f6e5, 859}, {0x1f6e9, 860},
            {0x1f6eb, 861}, {0x1f6ec, 862}, {0x1f6f0, 863}, {0x1f6f3, 864}, {0x1f6f4, 865}, {0x1f6f5, 866}, {0x1f6f6, 867},
            {0x1f6f7, 868}, {0x1f6f8, 869}, {0x1f6f9, 870}, {0x1f6fa, 871}, {0x1f7e0, 872}, {0x1f7e1, 873}, {0x1f7e2, 874},
            {0x1f7e3, 875}, {0x1f7e4, 876}, {0x1f7e5, 877}, {0x1f7e6, 878}, {0x1f7e7, 879}, {0x1f7e8, 880}, {0x1f7e9, 881},
            {0x1f7ea, 882}, {0x1f7eb, 883}, {0x1f90d, 884}, {0x1f90e, 885}, {0x1f90f, 886}, {0x1f910, 887}, {0x1f911, 888},
            {0x1f912, 889}, {0x1f913, 890}, {0x1f914, 891}, {0x1f915, 892}, {0x1f916, 893}, {0x1f917, 894}, {0x1f918, 895},
            {0x1f919, 896}, {0x1f91a, 897}, {0x1f91b, 898}, {0x1f91c, 899}, {0x1f91d, 900}, {0x1f91e, 901}, {0x1f91f, 902},
            {0x1f920, 903}, {0x1f921, 904}, {0x1f922, 905}, {0x1f923, 906}, {0x1f924, 907}, {0x1f925, 908}, {0x1f926, 909},
            {0x1f927, 910}, {0x1f928, 911}, {0x1f929, 912}, {0x1f92a, 913}, {0x1f92b, 914}, {0x1f92c, 915}, {0x1f92d, 916},
            {0x1f92e, 917}, {0x1f92f, 918}, {0x1f930, 919}, {0x1f931, 920}, {0x1f932, 921}, {0x1f933, 922}, {0x1f934, 923},
            {0x1f935, 924}, {0x1f936, 925}, {0x1f937, 926}, {0x1f938, 927}, {0x1f939, 928}, {0x1f93a, 929}, {0x1f93c, 930},
            {0x1f93d, 931}, {0x1f93e, 932}, {0x1f93f, 933}, {0x1f940, 934}, {0x1f941, 935}, {0x1f942, 936}, {0x1f943, 937},
            {0x1f944, 938}, {0x1f945, 939}, {0x1f947, 940}, {0x1f948, 941}, {0x1f949, 942}, {0x1f94a, 943}, {0x1f94b, 944},
            {0x1f94c, 945}, {0x1f94d, 946}, {0x1f94e, 947}, {0x1f94f, 948}, {0x1f950, 949}, {0x1f951, 950}, {0x1f952, 951},
            {0x1f953, 952}, {0x1f954, 953}, {0x1f955, 954}, {0x1f956, 955}, {0x1f957, 956}, {0x1f958, 957}, {0x1f959, 958},
            {0x1f95a, 959}, {0x1f95b, 960}, {0x1f95c, 961}, {0x1f95d, 962}, {0x1f95e, 963}, {0x1f95f, 964}, {0x1f960, 965},
            {0x1f961, 966}, {0x1f962, 967}, {0x1f963, 968}, {0x1f964, 969}, {0x1f965, 970}, {0x1f966, 971}, {0x1f967, 972},
            {0x1f968, 973}, {0x1f969, 974}, {0x1f96a, 975}, {0x1f96b, 976}, {0x1f96c, 977}, {0x1f96d, 978}, {0x1f96e, 979},
            {0x1f96f, 980}, {0x1f970, 981}, {0x1f971, 982}, {0x1f973, 983}, {0x1f974, 984}, {0x1f975, 985}, {0x1f976, 986},
            {0x1f97a, 987}, {0x1f97b, 988}, {0x1f97c, 989}, {0x1f97d, 990}, {0x1f97e, 991}, {0x1f97f, 992}, {0x1f980, 993},
            {0x1f981, 994}, {0x1f982, 995}, {0x1f983, 996}, {0x1f984, 997}, {0x1f985, 998}, {0x1f986, 999}, {0x1f987, 1000},
            {0x1f988, 1001}, {0x1f989, 1002}, {0x1f98a, 1003}, {0x1f98b, 1004}, {0x1f98c, 1005}, {0x1f98d, 1006}, {0x1f98e, 1007},
            {0x1f98f, 1008}, {0x1f990, 1009}, {0x1f991, 1010}, {0x1f992, 1011}, {0x1f993, 1012}, {0x1f994, 1013}, {0x1f995, 1014},
            {0x1f996, 1015}, {0x1f997, 1016}, {0x1f998, 1017}, {0x1f999, 1018}, {0x1f99a, 1019}, {0x1f99b, 1020}, {0x1f99c, 1021},
            {0x1f99d, 1022}, {0x1f99e, 1023}, {0x1f99f, 1024}, {0x1f9a0, 1025}, {0x1f9a1, 1026}, {0x1f9a2, 1027}, {0x1f9a5, 1028},
            {0x1f9a6, 1029}, {0x1f9a7, 1030}, {0x1f9a8, 1031}, {0x1f9a9, 1032}, {0x1f9aa, 1033}, {0x1f9ae, 1034}, {0x1f9af, 1035},
            {0x1f9b0, 1036}, {0x1f9b1, 1037}, {0x1f9b2, 1038}, {0x1f9b3, 1039}, {0x1f9b4, 1040}, {0x1f9b5, 1041}, {0x1f9b6, 1042},
            {0x1f9b7, 1043}, {0x1f9b8, 1044}, {0x1f9b9, 1045}, {0x1f9ba, 1046}, {0x1f9bb, 1047}, {0x1f9bc, 1048}, {0x1f9bd, 1049},
            {0x1f9be, 1050}, {0x1f9bf, 1051}, {0x1f9c0, 1052}, {0x1f9c1, 1053}, {0x1f9c2, 1054}, {0x1f9c3, 1055}, {0x1f9c4, 1056},
            {0x1f9c5, 1057}, {0x1f9c6, 1058}, {0x1f9c7, 1059}, {0x1f9c8, 1060}, {0x1f9c9, 1061}, {0x1f9ca, 1062}, {0x1f9cd, 1063},
            {0x1f9ce, 1064}, {0x1f9cf, 1065}, {0x1f9d0, 1066}, {0x1f9d1, 1067}, {0x1f9d2, 1068}, {0x1f9d3, 1069}, {0x1f9d4, 1070},
            {0x1f9d5, 1071}, {0x1f9d6, 1072}, {0x1f9d7, 1073}, {0x1f9d8, 1074}, {0x1f9d9, 1075}, {0x1f9da, 1076}, {0x1f9db, 1077},
            {0x1f9dc, 1078}, {0x1f9dd, 1079}, {0x1f9de, 1080}, {0x1f9df, 1081}, {0x1f9e0, 1082}, {0x1f9e1, 1083}, {0x1f9e2, 1084},
            {0x1f9e3, 1085}, {0x1f9e4, 1086}, {0x1f9e5, 1087}, {0x1f9e6, 1088}, {0x1f9e7, 1089}, {0x1f9e8, 1090}, {0x1f9e9, 1091},
            {0x1f9ea, 1092}, {0x1f9eb, 1093}, {0x1f9ec, 1094}, {0x1f9ed, 1095}, {0x1f9ee, 1096}, {0x1f9ef, 1097}, {0x1f9f0, 1098},
            {0x1f9f1, 1099}, {0x1f9f2, 1100}, {0x1f9f3, 1101}, {0x1f9f4, 1102}, {0x1f9f5, 1103}, {0x1f9f6, 1104}, {0x1f9f7, 1105},
            {0x1f9f8, 1106}, {0x1f9f9, 1107}, {0x1f9fa, 1108}, {0x1f9fb, 1109}, {0x1f9fc, 1110}, {0x1f9fd, 1111}, {0x1f9fe, 1112},
            {0x1f9ff, 1113}, {0x1fa70, 1114}, {0x1fa71, 1115}, {0x1fa72, 1116}, {0x1fa73, 1117}, {0x1fa78, 1118}, {0x1fa79, 1119},
            {0x1fa7a, 1120}, {0x1fa80, 1121}, {0x1fa81, 1122}, {0x1fa82, 1123}, {0x1fa90, 1124}, {0x1fa91, 1125}, {0x1fa92, 1126},
            {0x1fa93, 1127}, {0x1fa94, 1128}, {0x1fa95, 1129}, {0x203c, 1130}, {0x2049, 1131}, {0x20e3, 1132}, {0x2122, 1133},
            {0x2139, 1134}, {0x2194, 1135}, {0x2195, 1136}, {0x2196, 1137}, {0x2197, 1138}, {0x2198, 1139}, {0x2199, 1140},
            {0x21a9, 1141}, {0x21aa, 1142}, {0x231a, 1143}, {0x231b, 1144}, {0x2328, 1145}, {0x23cf, 1146}, {0x23e9, 1147},
            {0x23ea, 1148}, {0x23eb, 1149}, {0x23ec, 1150}, {0x23ed, 1151}, {0x23ee, 1152}, {0x23ef, 1153}, {0x23f0, 1154},
            {0x23f1, 1155}, {0x23f2, 1156}, {0x23f3, 1157}, {0x23f8, 1158}, {0x23f9, 1159}, {0x23fa, 1160}, {0x24c2, 1161},
            {0x25aa, 1162}, {0x25ab, 1163}, {0x25b6, 1164}, {0x25c0, 1165}, {0x25fb, 1166}, {0x25fc, 1167}, {0x25fd, 1168},
            {0x25fe, 1169}, {0x2600, 1170}, {0x2601, 1171}, {0x2602, 1172}, {0x2603, 1173}, {0x2604, 1174}, {0x260e, 1175},
            {0x2611, 1176}, {0x2614, 1177}, {0x2615, 1178}, {0x2618, 1179}, {0x261d, 1180}, {0x2620, 1181}, {0x2622, 1182},
            {0x2623, 1183}, {0x2626, 1184}, {0x262a, 1185}, {0x262e, 1186}, {0x262f, 1187}, {0x2638, 1188}, {0x2639, 1189},
            {0x263a, 1190}, {0x2640, 1191}, {0x2642, 1192}, {0x2648, 1193}, {0x2649, 1194}, {0x264a, 1195}, {0x264b, 1196},
            {0x264c, 1197}, {0x264d, 1198}, {0x264e, 1199}, {0x264f, 1200}, {0x2650, 1201}, {0x2651, 1202}, {0x2652, 1203},
            {0x2653, 1204}, {0x265f, 1205}, {0x2660, 1206}, {0x2663, 1207}, {0x2665, 1208}, {0x2666, 1209}, {0x2668, 1210},
            {0x267b, 1211}, {0x267e, 1212}, {0x267f, 1213}, {0x2692, 1214}, {0x2693, 1215}, {0x2694, 1216}, {0x2695, 1217},
            {0x2696, 1218}, {0x2697, 1219}, {0x2699, 1220}, {0x269b, 1221}, {0x269c, 1222}, {0x26a0, 1223}, {0x26a1, 1224},
            {0x26aa, 1225}, {0x26ab, 1226}, {0x26b0, 1227}, {0x26b1, 1228}, {0x26bd, 1229}, {0x26be, 1230}, {0x26c4, 1231},
            {0x26c5, 1232}, {0x26c8, 1233}, {0x26ce, 1234}, {0x26cf, 1235}, {0x26d1, 1236}, {0x26d3, 1237}, {0x26d4, 1238},
            {0x26e9, 1239}, {0x26ea, 1240}, {0x26f0, 1241}, {0x26f1, 1242}, {0x26f2, 1243}, {0x26f3, 1244}, {0x26f4, 1245},
            {0x26f5, 1246}, {0x26f7, 1247}, {0x26f8, 1248}, {0x26f9, 1249}, {0x26fa, 1250}, {0x26fd, 1251}, {0x2702, 1252},
            {0x2705, 1253}, {0x2708, 1254}, {0x2709, 1255}, {0x270a, 1256}, {0x270b, 1257}, {0x270c, 1258}, {0x270d, 1259},
            {0x270f, 1260}, {0x2712, 1261}, {0x2714, 1262}, {0x2716, 1263}, {0x271d, 1264}, {0x2721, 1265}, {0x2728, 1266},
            {0x2733, 1267}, {0x2734, 1268}, {0x2744, 1269}, {0x2747, 1270}, {0x274c, 1271}, {0x274e, 1272}, {0x2753, 1273},
            {0x2754, 1274}, {0x2755, 1275}, {0x2757, 1276}, {0x2763, 1277}, {0x2764, 1278}, {0x2795, 1279}, {0x2796, 1280},
            {0x2797, 1281}, {0x27a1, 1282}, {0x27b0, 1283}, {0x27bf, 1284}, {0x2934, 1285}, {0x2935, 1286}, {0x2b05, 1287},
            {0x2b06, 1288}, {0x2b07, 1289}, {0x2b1b, 1290}, {0x2b1c, 1291}, {0x2b50, 1292}, {0x2b55, 1293}, {0x3030, 1294},
            {0x303d, 1295}, {0x3297, 1296}, {0x3299, 1297},
        };

        public static readonly HashSet<int> SingleCharEmojiCodePoints = new HashSet<int> {
            0x203c, 0x2049, 0x20e3, 0x2122, 0x2139, 0x2194, 0x2195, 0x2196, 0x2197, 0x2198, 0x2199, 0x21a9,
            0x21aa, 0x231a, 0x231b, 0x2328, 0x23cf, 0x23e9, 0x23ea, 0x23eb, 0x23ec, 0x23ed, 0x23ee, 0x23ef,
            0x23f0, 0x23f1, 0x23f2, 0x23f3, 0x23f8, 0x23f9, 0x23fa, 0x24c2, 0x25aa, 0x25ab, 0x25b6, 0x25c0,
            0x25fb, 0x25fc, 0x25fd, 0x25fe, 0x2600, 0x2601, 0x2602, 0x2603, 0x2604, 0x260e, 0x2611, 0x2614, 
            0x2615, 0x2618, 0x261d, 0x2620, 0x2622, 0x2623, 0x2626, 0x262a, 0x262e, 0x262f, 0x2638, 0x2639, 
            0x263a, 0x2640, 0x2642, 0x2648, 0x2649, 0x264a, 0x264b, 0x264c, 0x264d, 0x264e, 0x264f, 0x2650,
            0x2651, 0x2652, 0x2653, 0x265f, 0x2660, 0x2663, 0x2665, 0x2666, 0x2668, 0x267b, 0x267e, 0x267f,
            0x2692, 0x2693, 0x2694, 0x2695, 0x2696, 0x2697, 0x2699, 0x269b, 0x269c, 0x26a0, 0x26a1, 0x26aa,
            0x26ab, 0x26b0, 0x26b1, 0x26bd, 0x26be, 0x26c4, 0x26c5, 0x26c8, 0x26ce, 0x26cf, 0x26d1, 0x26d3,
            0x26d4, 0x26e9, 0x26ea, 0x26f0, 0x26f1, 0x26f2, 0x26f3, 0x26f4, 0x26f5, 0x26f7, 0x26f8, 0x26f9,
            0x26fa, 0x26fd, 0x2702, 0x2705, 0x2708, 0x2709, 0x270a, 0x270b, 0x270c, 0x270d, 0x270f, 0x2712,
            0x2714, 0x2716, 0x271d, 0x2721, 0x2728, 0x2733, 0x2734, 0x2744, 0x2747, 0x274c, 0x274e, 0x2753, 
            0x2754, 0x2755, 0x2757, 0x2763, 0x2764, 0x2795, 0x2796, 0x2797, 0x27a1, 0x27b0, 0x27bf, 0x2934,
            0x2935, 0x2b05, 0x2b06, 0x2b07, 0x2b1b, 0x2b1c, 0x2b50, 0x2b55, 0x3030, 0x303d, 0x3297, 0x3299
        };

        public const int rowCount = 36;
        public const int colCount = 37;
        public static float advanceFactor = 1.3f;
        public static float sizeFactor = 1.2f;

        public static Rect getMinMaxRect(float fontSize, float ascent, float descent) {
            return Rect.fromLTWH((advanceFactor - sizeFactor) / 2 * fontSize,
                descent - fontSize * sizeFactor,
                fontSize * sizeFactor,
                fontSize * sizeFactor);
        }

        public static Rect getUVRect(int code) {
            bool exist = emojiLookupTable.TryGetValue(code, out int index);
            if (exist) {
                return Rect.fromLTWH(
                    (index % colCount) * (1.0f / colCount),
                    (rowCount - 1 - (index / colCount)) * (1.0f / rowCount),
                    1.0f / colCount, 1.0f / rowCount);
            }

            D.assert(() => {
                Debug.LogWarning($"Unrecognized unicode for emoji {code:x}");
                return true;
            });
            return Rect.fromLTWH(0, 0, 0, 0);
        }

        public static bool isSingleCharEmoji(int c) {
            return isSingleCharNonEmptyEmoji(c) || isEmptyEmoji(c);
        }

        public static bool isSingleCharNonEmptyEmoji(int c) {
            return SingleCharEmojiCodePoints.Contains(c);
        }

        public static bool isEmptyEmoji(int c) {
            return c == 0xFE0F;
        }

        public static List<string> splitByEmoji(string text) {
            int start = 0;
            bool? currentEmoji = null;
            List<string> list = new List<string>();

            for (int i = 0; i < text.Length; i++) {
                if (i < text.Length - 1 && char.IsHighSurrogate(text[i]) && char.IsLowSurrogate(text[i + 1])) {
                    if (currentEmoji != true) {
                        if (i > start) {
                            list.Add(text.Substring(start, i - start));
                            start = i;
                        }
                    }

                    i++;
                    currentEmoji = true;
                }
                else if (isSingleCharEmoji(text[i])) {
                    if (currentEmoji != true) {
                        if (i > start) {
                            list.Add(text.Substring(start, i - start));
                            start = i;
                        }
                    }

                    currentEmoji = true;
                }
                else {
                    if (currentEmoji != false) {
                        if (i > start) {
                            list.Add(text.Substring(start, i - start));
                            start = i;
                        }
                    }

                    currentEmoji = false;
                }
            }

            if (start < text.Length) {
                list.Add(text.Substring(start));
            }

            return list;
        }
    }
}