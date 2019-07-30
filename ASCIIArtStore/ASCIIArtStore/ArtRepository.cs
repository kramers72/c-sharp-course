using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArtStore
{
    //https://www.asciiart.eu/
    class ArtRepository
    {
        public List<ASCIICategory> Categories { get; private set; }

        public ArtRepository()
        {
            InitializeData();
        }

        public string GetBanner()
        {
            return _banner;
        }


        public void AddASCIIArt(string ascii, ASCIICategory category)
        {
            ASCIIArt art = new ASCIIArt
            {
                Id = category.ASCIIArtPieces.Max(a => a.Id) + 1,
                ASCII = ascii,
                Category = category
            };
            category.ASCIIArtPieces.Add(art);
        }

        public void AddASCIICategory(string categoryDescription)
        {
            ASCIICategory newCat = new ASCIICategory
            {
                Id = Categories.Max(c => c.Id) + 1,
                Description = categoryDescription
            };
            Categories.Add(newCat);

        }

        #region Private methods

        private void InitializeData()
        {
            Categories = new List<ASCIICategory>();
            ASCIICategory bugCat = new ASCIICategory();
            bugCat.Id = 0;
            bugCat.Description = "Bugs";
            bugCat.ASCIIArtPieces = new List<ASCIIArt>()
                        {
                             new ASCIIArt() {Id = 0, Category = bugCat, Description = "Ant", ASCII = _ant1},
                             new ASCIIArt() {Id = 1, Category = bugCat, Description = "Bee", ASCII = _bee},
                             new ASCIIArt() {Id = 2, Category = bugCat, Description = "Beetle", ASCII = _beetle},
                        };


            Categories.Add(bugCat);

            ASCIICategory computers = new ASCIICategory();
            computers.Id = 1;
            computers.Description = "Computers";
            computers.ASCIIArtPieces = new List<ASCIIArt>()
                        {
                             new ASCIIArt() {Id = 3, Category = computers, Description = "Apple", ASCII = _apple},
                             new ASCIIArt() {Id = 4, Category = computers, Description = "Gameboy", ASCII = _gameboy},
                        };


            Categories.Add(computers);

            ASCIICategory simpsons = new ASCIICategory();
            simpsons.Id = 2;
            simpsons.Description = "Simpsons";
            simpsons.ASCIIArtPieces = new List<ASCIIArt>()
                        {
                             new ASCIIArt() {Id =5, Category = simpsons, Description = "Homer", ASCII = _homer},
                             new ASCIIArt() {Id = 6, Category = simpsons, Description = "Bart", ASCII = _bart},
                             new ASCIIArt() {Id = 7, Category = simpsons, Description = "Lisa", ASCII = _lisa},
                        };


            Categories.Add(simpsons);
        }

        #endregion

        #region Artwork

        private string _ant1 =
@"\("")/
-( )-
/(_)\";

        private string _bee =
@"        __
        _/__) 
       (8|)_}}- 
        `\__) ";

        private string _beetle =
@".   .
   \ /
 `/ ! \`
 | o:o |
~| o:o |~
/ \_:_/ \";

        private string _apple =
@"
    .__________________________.
    | .___________________. |==|
    | | ................. | |  |
    | | ::::Apple ][::::: | |  |
    | | ::::::::::::::::: | |  |
    | | ::::::::::::::::: | |  |
    | | ::::::::::::::::: | |  |
    | | ::::::::::::::::: | |  |
    | | ::::::::::::::::: | | ,|
    | !___________________! |(c|
    !_______________________!__!
   /                            \
  /  [][][][][][][][][][][][][]  \
 /  [][][][][][][][][][][][][][]  \
(  [][][][][____________][][][][]  )
 \ ------------------------------ /
  \______________________________/";

        private string _gameboy =
@"
     _______
    |.-----.|
    ||     ||
    ||_____/|
    | .     |
    |-|-  oo|
    |  _ _  |
    |       /
    --------;";

        private string _bart =
@"
 |\/\/\/|  
 |      |  
 |      |  
 | (o)(o)  
 C      _) 
  | ,___|  
  |   /    
 /____\    
/      \";

        private string _homer =
@"
   _&__      
  /     \     
 |       |    
 |  (o)(o)    
 C   .---_)   
  | |.___|    
  |  \__/     
  /_____\     
 /_____/ \    
/         \";

        private string _lisa =
@"
      /\  /\
  ___/  \/  \___
 |             /
 |            /_
 /     \_| \_| /
/     \/  \/  \/
\     (o   )o  )
 \ /c  \__/ --.
 | \_  ,     -'
 |_ | '\_______)
   ||      _)
    |     |
    ooooooo
   /       \";

        private string _banner =
@"
      .,:;:;,.
    .:;:;::,;::
    :;'''`' `':'
    ::-(.)-(.):;
    :`    c   ':      
    ::`.  o .':;    
    :;::`~~'::::      
  ..::;: `  ::;:,.    
.'     :    ;     `.  
:       `'''       ;
:   .          .   :
:   : ASCIIART ;   ;
:   ;  RULES!  :   :
:   :          :   :
:   :          :   ;
:...:          :...;
 ::::..........:;;;
    :          :
    :    :     : ";

        #endregion
    }
}
