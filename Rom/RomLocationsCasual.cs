//nothing hidden, items are hidden the way they should be
//no limitations
//                                   NoHidden = true,
//                                   ItemStorageType = ItemStorageType.Hidden, {chozo,hidden, blank}


using System;
using System.Collections.Generic;
using System.Linq;
using SuperMetroidRandomizer.Random;

namespace SuperMetroidRandomizer.Rom
{
    public class RomLocationsCasual : IRomLocations
    {
        public List<Location> Locations { get; set; }
        public string DifficultyName { get { return "Casual"; } }
        public string SeedFileString { get { return "C{0:0000000}"; } }
        public string SeedRomString { get { return "SMRv{0} C{1}"; } }

        public void ResetLocations()
        {
            Locations = new List<Location>
                       {
                           new Location
                               {
                                   NoHidden = true, //ok
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Power Bomb (Crateria surface)",
                                   //Address = 0x781CC,
                                   //SMPB 0.7.2 address
                                   Address = 0x781D4,
                                   CanAccess =
                                       have =>
									CanUsePowerBombs(have)
									&& (have.Contains(ItemType.SpeedBooster)
										|| have.Contains(ItemType.SpaceJump)),
                               },
                           new Location
                               { 
                                   NoHidden = true, //ok							   
                                   GravityOkay = false,
                                   Region = Region.Crateria,
                                   Name = "Missile (Underwater outside Wrecked Ship)",
								   //originally 0x781E8
                                   Address = 0x7EEAC,
                                   CanAccess =
                                       have => 
									CanAccessWs(have),
                               },
                           new Location
                               {     
                                   NoHidden = true,	
                                   GravityOkay = false,                                   
                                   Region = Region.Crateria,
                                   Name = "Missile (outside Wrecked Ship top)",
								   //0x781EE
                                   Address = 0x7EEB2,
                                   CanAccess =
                                       have =>
                                    CanAccessWs(have),
                               },
                           new Location
                               {       
                                   NoHidden = true, //ok	
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Missile (outside WS under super block)",
								   //0x781F4
                                   Address = 0x7EEB8,
                                   CanAccess =
                                       have => 
                                    CanAccessWs(have),
										//needs morph as well in case of supers only
                               },
                           new Location
                               {        
                                   NoHidden = true, //ok
                                   GravityOkay = false,   
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria moat)",
                                   Address = 0x78248,
                                   CanAccess =
                                       have =>
                                       CanAccessWs(have),
                               },
                           new Location
                               {       
                                   NoHidden = true, //ok
                                   GravityOkay = false,    
                                   Region = Region.Crateria,
                                   Name = "Energy Tank (Crateria gauntlet)",
								   //0x78264
                                   Address = 0x7846A,
                                   CanAccess =
                                       have =>
                                       CanEnterAndLeaveGauntlet(have)
                                   	&& EnergyReserveCount(have) >= 1,
                               },
                           new Location
                               {        
                                   NoHidden = true, //ok	
                                   GravityOkay = false,    
                                   Region = Region.Crateria,
                                   Name = "Bomb",
                                   Address = 0x78404,
                                   CanAccess =
                                       have =>
                                       CanOpenMissileDoors(have)
									   && have.Contains(ItemType.MorphingBall),
											//it might be important to consider casual players who cant alcatraz
											//maybe change the bomb blocks to shot blocks, with visual indication?
                               },
                           new Location
                               {     
                                   NoHidden = true, //ok	
                                   GravityOkay = false,   
                                   Region = Region.Crateria,
                                   Name = "Energy Tank (Crateria terminator)",
                                   Address = 0x78432,
                                   CanAccess = 
                                       have => 
                                   	CanEnterPassages(have),
                               },
                            new Location
                               {        
                                   NoHidden = true, //ok	
                                   GravityOkay = false,    
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria old MB missiles)",
								   //0x783EE
                                   Address = 0x7F39E,
                                   CanAccess =
                                       have => 
                                       have.Contains(ItemType.MorphingBall)
                                   	&& (have.Contains(ItemType.Bomb)
        	            || have.Contains(ItemType.PowerBomb)
        	            || have.Contains(ItemType.ScrewAttack)),
										//CanEnterPassages || morph+screw
                               },
                           new Location
                               {       
                                   NoHidden = true, //ok	
                                   GravityOkay = false,   
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria 2st gauntlet missiles)",
                                   Address = 0x78464,
                                   CanAccess =
                                       have =>
                                       CanEnterAndLeaveGauntlet(have)
                                   	&& EnergyReserveCount(have) >= 1,
											//now possible to get in from underneath, just need morph
                               },
                           new Location
                               {     
                                   NoHidden = true, //ok	
                                   GravityOkay = false,   
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria 1st gauntlet missiles)",
								   //0x7846A-is crateria etank or 0x78264
                                   //Address = 0x78464,
                                   Address= 0x78264,
                                   CanAccess =
                                       have =>
                                       CanEnterAndLeaveGauntlet(have),
                               },
                           new Location
                               {     
                                   NoHidden = true,	//ok
                                   GravityOkay = false,    
                                   Region = Region.Crateria,
                                   Name = "Super Missile (Crateria supers)",
                                   Address = 0x78478,
                                   CanAccess =
                                       have =>
                                       CanUsePowerBombs(have)
									   && have.Contains(ItemType.SpeedBooster)
                                   	&& have.Contains(ItemType.IceBeam),
                               },
                           new Location
                               {       
                                   NoHidden = true,	//ok
                                   GravityOkay = false,     
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria Final Missiles)",
                                   Address = 0x78486,
                                   CanAccess =
                                       have =>
                                       CanEnterPassages(have),
                               },
							   new Location
                               {        
                                   NoHidden = true, //ok	
                                   GravityOkay = false,     
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria Map Station Missiles)",
								   //Map missiles #1
                                   Address = 0x78444,
                                   CanAccess =
                                       have =>
                                   	CanOpenMissileDoors(have),
                               },
                           new Location
                               {        
                                   NoHidden = true,	//ok
                                   GravityOkay = false,
                                   Region = Region.GreenBrinstar,
                                   Name = "Power Bomb (Brinstar Etecoons)",
                                   Address = 0x784AC,
                                   CanAccess =
                                       have => 
                                   	CanMeetEtecoons(have),
                               },
                           new Location
                               {        
                                   NoHidden = true, //ok	
                                   GravityOkay = false,  
                                   Region = Region.PinkBrinstar,
                                   Name = "Super Missile (Spospo Supers)",
								   //0x784E4
                                   Address = 0x7F31C,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessPinkBrinstar(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {            
                                   NoHidden = true, //ok
                                   GravityOkay = false, 
                                   Region = Region.GreenBrinstar,
                                   Name = "Missile (Brinstar below Early Supers)",
                                   Address = 0x78518,
                                   CanAccess =
                                       have =>
                                       CanAccessGreenBrinstar(have)
                                       && CanOpenMissileDoors(have)
									   && have.Contains(ItemType.MorphingBall),
									   //canbackflip to remove morphball req
                               },
                           new Location
                               {            
                                   NoHidden = true, //ok	
                                   GravityOkay = false,   
                                   Region = Region.GreenBrinstar,
                                   Name = "Super Missile (Brinstar Early Supers)",
                                   Address = 0x7851E,
                                   CanAccess =
                                       have =>
                                       CanAccessGreenBrinstar(have)
                                       && CanOpenMissileDoors(have)
									   && CanSpeedball(have),
									   //missiles+morph only
                               },
                           new Location
                               {           
                                   NoHidden = true,	 //ok
                                   GravityOkay = false,   
                                   Region = Region.GreenBrinstar,
                                   Name = "Reserve Tank (Brinstar Reserve)",
                                   Address = 0x7852C,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessGreenBrinstar(have)
                                       && CanOpenMissileDoors(have)
									   && CanSpeedball(have),
									   //missiles+morph only
                               },
                           new Location
                               {            
                                   NoHidden = true,	 //ok
                                   GravityOkay = false,   
                                   Region = Region.GreenBrinstar,
                                   Name = "Missile (Brinstar Reserve Ron Popeil Missiles)",
                                   Address = 0x78532,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessGreenBrinstar(have)
                                       && CanOpenMissileDoors(have)
									   && CanSpeedball(have)
									   && CanEnterPassages(have),
									   //missiles+morph only
                               },
                           new Location
                               {             
                                   NoHidden = true, //ok	
                                   GravityOkay = false,  
                                   Region = Region.GreenBrinstar,
                                   Name = "Missile (Brinstar Reserve Missiles)",
                                   Address = 0x78538,
                                   CanAccess =
                                       have =>
                                       CanAccessGreenBrinstar(have)
                                       && CanOpenMissileDoors(have)
									   && CanSpeedball(have),
									   //missiles+morph only
                               },
                           new Location
                               {             
                                   NoHidden = true,	 //ok
                                   GravityOkay = false,    
                                   Region = Region.PinkBrinstar,
                                   Name = "Missile (Big Pink Brinstar top)",
                                   Address = 0x78608,
                                   CanAccess =
                                       have =>
                                       CanAccessPinkBrinstar(have)
                                   	&& (have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpaceJump)),
                                   //Speedrunner has none of the 3
                               },
                           new Location
                               {            
                                   NoHidden = true, //ok	
                                   GravityOkay = false,    
                                   Region = Region.PinkBrinstar,
                                   Name = "Missile (Big Pink Brinstar Charge Missiles)",
                                   Address = 0x7860E,
                                   CanAccess =
                                       have =>
                                   	CanAccessPinkBrinstar(have),
                               },
                           new Location
                               {             
                                   NoHidden = true, //ok	
                                   GravityOkay = false,      
                                   Region = Region.PinkBrinstar,
                                   Name = "Charge Beam",
                                   Address = 0x78614,
                                   CanAccess =
                                       have =>
                                   	CanAccessPinkBrinstar(have),
                               },
                           new Location
                               {            
                                   NoHidden = true,	 //ok
                                   GravityOkay = false,     
                                   Region = Region.PinkBrinstar,
                                   Name = "Power Bomb (Pink Brinstar Power Bombs)",
								   //0x7865C
                                   Address = 0x7F232,
                                   CanAccess =
                                       have =>
                                       CanAccessPinkBrinstar(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& (have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpaceJump)),
                              },
                           new Location
                               {           
                                   NoHidden = true,	 //ok
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Missile (Brinstar Pipe Missiles)",
                                   Address = 0x78676,
                                   CanAccess =
                                       have =>
                                   	CanEnterPassages(have)
                                   	|| CanAccessPinkBrinstar(have)
                               },
                           new Location
                               {           
                                   NoHidden = true, //ok
                                   GravityOkay = false,              
                                   Region = Region.Brinstar,
								   //This slot changes according to what can and can't be obtained in the randomizer.
                                   Name = "Morphing Ball",   						   
                                   //Address = 0x786DE,
                                   //0.7.2 Address
                                   Address = 0x7867E,
                                   CanAccess = 
                                       have => 
                                   	true,
                               },
                           new Location
                               {              
                                   NoHidden = true,
                                   GravityOkay = false,      
                                   Region = Region.Brinstar,
                                   Name = "Power Bomb (Blue Brinstar)",
                                   //Address = 0x7874C,
                                   //0.7.2 Address
                                   Address = 0x78684,
                                   CanAccess =
                                       have => 
                                   	CanUsePowerBombs(have),
                               },
                           new Location
                               {              
                                   NoHidden = true,	 //ok
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Missile (Blue Brinstar middle)",
								   //0x78798
                                   Address = 0x7EBB8,
                                   CanAccess =
                                       have =>
                                       //CanOpenMissileDoors(have)
                                   	//for some reason, the door is blue instead of red
                                   	//might have to do with the door flag patch
									   have.Contains(ItemType.MorphingBall),
                               },
                           new Location
                               {            
                                   NoHidden = true,	 //ok
                                   GravityOkay = false,   
                                   Region = Region.Brinstar,
                                   Name = "Energy Tank (Blue Brinstar)",
								   //0x7879E
                                   Address = 0x7EBBE,
                                   CanAccess =
                                       have =>
                                   	CanOpenMissileDoors(have),
                               },
                           new Location
                               {            
                                   NoHidden = true,	//ok
                                   GravityOkay = false,  
                                   Region = Region.GreenBrinstar,
                                   Name = "Energy Tank (Brinstar near Etecoons E-tank)",
								   //0x787C2
                                   Address = 0x7F4F2,
                                   CanAccess =
                                       have => 
                                   	CanMeetEtecoons(have),
									   //|| CanEnterPassages is the backflip method
                               },
                           new Location
                               {            
                                   NoHidden = true,	//ok
                                   GravityOkay = false,    
                                   Region = Region.GreenBrinstar,
                                   Name = "Super Missile (Brinstar near Etecoons)",
								   //0x787D0
                                   Address = 0x7F9CC,
                                   CanAccess =
                                       have =>
                                       CanMeetEtecoons(have),
									   //|| CanEnterPassages is the backflip method
                               },
                           new Location
                               {          
                                   NoHidden = true,	 //ok
                                   GravityOkay = false,    
                                   Region = Region.PinkBrinstar,
                                   Name = "Energy Tank (Pink Brinstar under Charge Beam)",
                                   Address = 0x787FA,
                                   CanAccess =
                                       have =>
                                   	CanAccessPinkBrinstar(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.SpeedBooster),
                               },
                           new Location
                               {            
                                   NoHidden = true,	 //ok
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Missile (Blue Brinstar First Missiles)",
								   //0x78802
                                   Address = 0x7EAC8,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess = 
                                       have => 
                                   	have.Contains(ItemType.MorphingBall),
                               },
                           new Location
                               {             
                                   NoHidden = true,	//ok
                                   GravityOkay = false,     
                                   Region = Region.PinkBrinstar,
                                   Name = "Energy Tank (Pink Brinstar Hoppers Room)",
                                   Address = 0x78824,
                                   CanAccess =
                                       have =>
                                       CanUsePowerBombs(have)
                                   	&& CanAccessPinkBrinstar(have),
                               },
                           new Location
                               {           
                                   NoHidden = true, //ok
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Missile (Blue Brinstar upper Billy Mays)",
								   //0x78836
                                   Address = 0x7EBC4,
                                   CanAccess =
                                       have =>
                                   	CanOpenMissileDoors(have)
                                   	&& (have.Contains(ItemType.ScrewAttack)
                                   	&& have.Contains(ItemType.SpaceJump)),
                               },
                           new Location
                               {           
                                   NoHidden = true, //ok
                                   GravityOkay = false,   
                                   Region = Region.Brinstar,
                                   Name = "Missile (Blue Brinstar lower Billy Mays)",
								   //0x7883C
                                   Address = 0x7EBCA,
                                   CanAccess =
                                       have =>
                                   	CanOpenMissileDoors(have)
                                   	&& have.Contains(ItemType.MorphingBall),
                               },
                           new Location
                               {           
                                   NoHidden = true, //ok
                                   GravityOkay = false,      
                                   Region = Region.RedBrinstar,
                                   Name = "X-Ray Visor",
                                   //Address = 0x78876,
                                   //0.7.2 Address
                                   Address = 0x7FFD1,
                                   //ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                   	(CanAccessPinkBrinstar(have)
                                       && have.Contains(ItemType.SuperMissile)
                                       && have.Contains(ItemType.MorphingBall)
                                       && have.Contains(ItemType.GrappleBeam))
                                   	//lots of spikes, might need grapple/space/speedboost for casuals
									   || (have.Contains(ItemType.GrappleBeam)
                                   	    && CanAccessRedBrinstar(have)
                                   	    && CanUsePowerBombs(have)),
                               },
                           new Location
                               {           
                                   NoHidden = true, //ok
                                   GravityOkay = false,            
                                   Region = Region.RedBrinstar,
                                   Name = "Power Bomb (Beta Power Bomb Room)",
                                   Address = 0x788CA,
                                   CanAccess =
                                       have =>
                                       CanAccessRedBrinstar(have)
									   && have.Contains(ItemType.SuperMissile)
									   && CanUsePowerBombs(have),
                               },
                           new Location
                               {            
                                   NoHidden = true, //ok
                                   GravityOkay = false,        
                                   Region = Region.RedBrinstar,
                                   Name = "Power Bomb (Alpha Power Bomb Room)",
                                   Address = 0x7890E,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessRedBrinstar(have)
									   && have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {              
                                   NoHidden = true, //ok
                                   GravityOkay = false,     
                                   Region = Region.RedBrinstar,
                                   Name = "Missile (Alpha Power Bomb Room)",
                                   Address = 0x78914,
                                   CanAccess =
                                       have =>
                                       CanAccessRedBrinstar(have)
                                   	&& CanDestroyBombBlocks(have),
                               },
                           new Location
                               {     
								NoHidden = true, //ok
                                   GravityOkay = false, 
                                   Region = Region.RedBrinstar,
                                   Name = "Spazer",
                                   Address = 0x7896E,
                                   CanAccess =
                                       have =>
                                   	CanAccessRedBrinstar(have)
									&& have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {           
									NoHidden = true,//ok
                                   GravityOkay = false,
                                   Region = Region.Kraid,
                                   Name = "Energy Tank (Kraid)",
								   //0x7899C --> Vanilla Address
                                   //Address = 0x7FC8A, --> Project Base Address, causes crash upon entering Kraid's Lair
                                   //Address = 0x7899C,
                                   //Address = 0x7FC66, --> scroll plm
                                   //Address = 0x7FC8A,
                                   //0.7.2 address
                                   Address = 0x7FC7E,
                                   //does not randomize
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessRedBrinstar(have)
                                       && CanDefeatKraid(have),
                               },
                           new Location
                               {           
                                   NoHidden = true,//ok
                                   GravityOkay = false,  
                                   Region = Region.Kraid,
                                   Name = "Missile (Kraid)",
								   //0x789EC --> Vanilla Address
                                   //Address = 0x7FC05,  --> Project Base Address, MAY cause crash upon entering Kraid's Lair
                                   //Address = 0x789EC,
                                   Address = 0x7FC06,
                                   //does not randomize
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessRedBrinstar(have)
                                       && CanDefeatKraid(have),
                               },
                           new Location
                               {            
                                   NoHidden = true, //ok
                                   GravityOkay = false,  
                                   Region = Region.Kraid,
                                   Name = "Varia Suit",
								   //0x78ACA
                                   Address = 0x7F150,
                                   CanAccess =
                                       have =>
                                       (CanAccessRedBrinstar(have)
                                   	 && CanDefeatKraid(have)),
                                   	       // || have.Contains(ItemType.SpeedBooster))),
                                   	    //speedbooster is a bit technical
									   
									   //CanBackdoor with varia
									   //CanBackdoor with missiles+morph via maridia corridor
                               },
							   new Location
                               {            
                                   NoHidden = true, //ok
                                   GravityOkay = false,  
                                   Region = Region.GreenBrinstar,
								   //Map Missiles #2
                                   Name = "Missile (Brinstar Map Station Missiles)",
                                   Address = 0x7F9C6,
                                   CanAccess =
                                       have =>
                                   	CanAccessGreenBrinstar(have)
                                   	&& CanOpenMissileDoors(have),
                               },
                           new Location
                               {              
                                   NoHidden = true,//NOT OK
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Cathedral Missiles)",
								   //0x78AE4
                                   // Address = 0x7F600, is also incorrect *aka lava room*
                                   //Address = 0x78AE4,
                                   Address = 0x7F600,
                                   CanAccess =
                                       have =>
                                   	CanAccessHeatedNorfair(have),
                                   //short hellrun
                               },
                           new Location
                               {                    
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Ice Beam",
                                   Address = 0x78B24,
                                   CanAccess =
                                       have =>
                                   	CanAccessIceBeam(have)
									|| CanAccessIceBeam(have)
									&& have.Contains(ItemType.SuperMissile),
                                   //short hellrun
                               },
                           new Location
                               {                  
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Left Grapple Missiles)",
								   //0x78B46
                                   Address = 0x7EFA6,
                                   CanAccess =
                                       have =>
                                       CanAccessIceBeam(have)
                                   || (CanAccessCrocomire(have)
                                   	    && CanEnterPassages(have)),

										//can defeat either Crocomire or Ridley+enter passages
                               },
                           new Location
                               {                   
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Energy Tank (Crocomire)",
								   //0x78BA4
                                   Address = 0x7F5D6,
                                   CanAccess =
                                       have =>
                                       (CanAccessIceBeam(have)
                                   	&& CanEnterPassages(have))//almost or no hellrun
                                   || CanAccessCrocomire(have),
                               },
                           new Location
                               {                    
                                   NoHidden = true, //ok
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Hi-Jump Boots",
                                   Address = 0x78BAC,
                                   CanAccess =
                                       have =>
                                   	CanAccessRedBrinstar(have)
                                   	&& CanEnterPassages(have),//no hellrun
                               },
                           new Location
                               {                   
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Crocomire Escape)",
								   //0x78BC0
                                   Address = 0x7FE1A,
                                   CanAccess =
                                       have =>
                                   	CanAccessRedBrinstar(have),//20 energy hellrun??
                               },
                           new Location
                               {                   
                                   NoHidden = true, //ok
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Hi-Jump Boots)",
                                   Address = 0x78BE6,
                                   CanAccess =
                                       have =>
                                   	CanAccessRedBrinstar(have)
                                   	&& CanEnterPassages(have),//no hellrun
                               },
                           new Location
                               {                    
                                   NoHidden = true, //ok
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Energy Tank (Hi-Jump Boots)",
                                   Address = 0x78BEC,
                                   CanAccess =
                                       have =>
                                       CanAccessRedBrinstar(have)
                                   	&& CanEnterPassages(have),//no hellrun
                               },
                           new Location
                               {                    
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Power Bomb (Grapple Power Bombs)",
								   //0x78C04
                                   //Address = 0x7FCC6,
                                   Address = 0x7FCC6,
                                   CanAccess =
                                       have =>
                                   	(have.Contains(ItemType.SpeedBooster)
                                   	|| have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpaceJump))
                                     && ((CanAccessIceBeam(have)
                                   	&& CanEnterPassages(have))//almost or no hellrun
                                   	|| CanAccessCrocomire(have)),
                                   //Can backdoor via backflip+morph
                               },
                           new Location
                               {                    
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Crocomire)",
								   //0x78C14
                                   //Address = 0x78BA4,
                                   Address = 0x78BA4,
                                   CanAccess =
                                       have =>
                                   	CanAccessCrocomire(have)
									&& (have.Contains(ItemType.SpeedBooster)
                                   	|| have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpaceJump)), //crocomire etank is replaced by missiles
                               },
                           new Location
                               {                   
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Right Grapple Missiles)",
								   //0x78C2A
                                   // Address = 0x78BA4, is also incorrect
                                   //Address = 0x78C2A,
                                   Address = 0x7FCC0,
                                   CanAccess =
                                       have =>
                                       (have.Contains(ItemType.SpeedBooster)
                                   	|| have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpaceJump))
                                     && ((CanAccessIceBeam(have)
                                   	&& CanEnterPassages(have))//almost or no hellrun
                                   	|| CanAccessCrocomire(have)),
                                   //Can backdoor via backflip+morph
                               },
                           new Location
                               {                     
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Grapple Beam",
								   //0x78C36
                                   Address = 0x7EFA0,
                                   //ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       ((CanAccessIceBeam(have)
                                   	&& CanEnterPassages(have))//almost or no hellrun
                                   	|| CanAccessCrocomire(have)),
                                   //Can backdoor via backflip+morph
                               },
                           new Location
                               {                  
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Reserve Tank (Norfair Reserves)",
								   //0x78C3E
                                   Address = 0x7F648,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                   	CanAccessHeatedNorfair(have)
									&& have.Contains(ItemType.SuperMissile)
									&& have.Contains(ItemType.GrappleBeam),
                               },
                           new Location
                               {                  
                                   NoHidden = true,//likely ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Norfair Reserves 2nd Missiles)",
								   //0x78C44
                                   Address = 0x7F642,
                                   CanAccess =
                                       have =>
                                   	CanAccessHeatedNorfair(have)
									&& have.Contains(ItemType.SuperMissile)
									&& have.Contains(ItemType.GrappleBeam),
                               },
                           new Location
                               {                 
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Norfair Reserves 1st Missiles)",
								   //0x78C52
                                   Address = 0x7F63C,
                                   CanAccess =
                                       have =>
                                   	CanAccessHeatedNorfair(have)
									&& have.Contains(ItemType.SuperMissile)
									&& have.Contains(ItemType.GrappleBeam),
                               },
                           new Location
                               {                       
                                   NoHidden = true,//likely ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Bubble Mountain)",
								   //0x78C66
                                   Address = 0x78166,
                                   CanAccess =
                                       have =>
                                   	CanAccessHeatedNorfair(have),
                               },
                           new Location
                               {                     
                                   NoHidden = true,//likely ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Speed Booster)",
                                   Address = 0x78C74,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                   	(CanAccessHeatedNorfair(have)//2 main routes to speedboost, kraid backdoor or business center
                                   	|| (CanAccessHeatedNorfair(have)
                                   	     && CanUsePowerBombs(have))),
                               },
                           new Location
                               {                     
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Speed Booster",
                                   Address = 0x78C82,
                                   CanAccess =
                                       have =>
                                   	(CanAccessHeatedNorfair(have)//2 main routes to speedboost, kraid backdoor or business center
									&& CanOpenMissileDoors(have)
                                   	|| (CanAccessHeatedNorfair(have)
                                   	     && CanUsePowerBombs(have))),
                               },
                           new Location
                               {                      
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Wave/LN Escape Missiles)",
								   //0x78CBC
                                   Address = 0x7816C,
                                   CanAccess =
                                       have =>
                                   	CanAccessHeatedNorfair(have)
                                   	&& have.Contains(ItemType.HiJumpBoots),
                               },
                           new Location
                               {                     
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Wave Beam",
								   //0x78CCA
                                   Address = 0x78172,
                                   CanAccess =
                                       have =>
                                   	CanAccessHeatedNorfair(have)
									&& CanOpenMissileDoors(have)
                                   	&& (have.Contains(ItemType.SpeedBooster)
                                   	|| have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpaceJump)), //speedrunners won't need any of these
                               },
                           new Location
                               {                     
                                   NoHidden = true,//likely ok
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Missile (Gold Torizo)",
                                   Address = 0x78E6E,
                                   CanAccess =
                                       have =>
                                   	CanAccessLowerNorfair(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.ChargeBeam),
                               },
                           new Location
                               {                     
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Super Missile (Gold Torizo)",
                                   Address = 0x78E74,
                                   CanAccess =
                                       have =>
                                       CanAccessLowerNorfair(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.ChargeBeam),
                               },
                           new Location
                               {                         
                                   NoHidden = true,//likely ok
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Missile (Mickey Mouse)",
                                   Address = 0x78F30,
                                   CanAccess =
                                       have =>
                                   	CanAccessLowerNorfair(have)
                                   	&& CanEnterPassages(have),
                               },
                           new Location
                               {                           
                                   NoHidden = true,//likely ok
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Missile (Spring Ball Maze)",
                                   Address = 0x78FCA,
                                   CanAccess =
                                       have =>
                                   	CanAccessLowerNorfair(have)
                                   	&& CanEnterPassages(have)
                                   	&& have.Contains(ItemType.SpringBall),
                               },
                           new Location
                               {                             
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Power Bomb (Spring Ball Maze)",
                                   Address = 0x78FD2,
                                   CanAccess =
                                       have =>
                                       CanAccessLowerNorfair(have)
                                   	&& CanEnterPassages(have)
                                   	&& have.Contains(ItemType.SpringBall),
                               },
                           new Location
                               {                         
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Power Bomb (Power Bombs of Shame)",
                                   Address = 0x790C0,
                                   CanAccess =
                                       have =>
                                   	CanAccessLowerNorfair(have)
                                   	&& CanEnterPassages(have),
                               },
                           new Location
                               {                            
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Missile (FrankerZ)",
                                   Address = 0x79100,
                                   CanAccess =
                                       have =>
                                       CanAccessLowerNorfair(have)
                                   	&& CanEnterPassages(have),
                               },
                           new Location
                               {                         
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Energy Tank (Ridley)",
								   //0x79108
                                   Address = 0x7EA78,
                                   CanAccess =
                                       have =>
                                   	CanAccessLowerNorfair(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {                        
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Screw Attack",
                                   Address = 0x79110,
                                   CanAccess =
                                       have =>
                                       CanAccessLowerNorfair(have)
                                   	&& CanUsePowerBombs(have),
                               },
                           new Location
                               {                        
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Energy Tank (Lower Norfair Fire Flea E-tank)",
                                   Address = 0x79184,
                                   CanAccess =
                                       have =>
                                       CanAccessLowerNorfair(have)
									   && have.Contains(ItemType.SuperMissile)
									   && have.Contains(ItemType.SpaceJump)
									   && have.Contains(ItemType.IceBeam),
                               },
                           new Location
                               {                         
                                   NoHidden = true, //ok
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "Missile (Wrecked Ship Spike Room)",
                                   Address = 0x7C265,
                                   CanAccess =
                                       have => 
                                   	CanAccessWs(have),
                               },
                           new Location
                               {                           
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Reserve Tank (Wrecked Ship Reserves)",
                                   //does not randomize
                                   //I found 7B EF 53 0B 81 00 at 0x78AA3 default roomstate
                                   //7B EF 53 0B 81 00 at 0x78A9E after phantoon roomstate
                                   Address = 0x78A9E,
                                   //Address = 0x78AA3,
                                   //Address = 0x7C2E9,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                   	CanAccessWs(have)
                                   	&& (have.Contains(ItemType.SpeedBooster) //no speedblocks in the area
                                   	|| have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpaceJump)), //none needed for speedrunner
                               },
                           new Location
                               {                           
                                   NoHidden = true,//ok
                                   //I found DB EE 3C 26 82 00 at 0x78AA9 default roomstate
                                   
                                   GravityOkay = true, //ok 
                                   Region = Region.WreckedShip,
                                   Name = "Missile (Wrecked Ship Reserves)",
                                   //Address = 0x7C2EF,
                                   //DB EE 3C 26 82 00 at 0x78AA4 after phantoon THIS IS THE WINNER
                                   Address = 0x78AA4,
                                   //Address = 0x78AA9,
                                   CanAccess =
                                       have => 
                                       CanAccessWs(have)
                                   	&& (have.Contains(ItemType.SpeedBooster)
                                   	|| have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpaceJump)), //none needed for speedrunner
                               },
                           new Location
                               {                          
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Missile (Wrecked Ship Attic)",
                                   //does not randomize Room at 7CA52
                                   //Missiles are EE DB
                                   //PLM index of 0
                                   //7C231 is the first PLM index of 7CA52 before Phantoon is killed
                                   //DB EE 9B 09 83 00
                                   
                                   //PLM index of 0
                                   //7C2FF is the first index of 7CA52 after Phantoon is killed
                                   //DB EE 9B 09 83 00
                                   
                                   //For the UNUSED ROOM - unpowered state
                                   //PLM index of 0
                                   //7C319
                                   //DB EE 2B 09 83 00
                                   
                                   //For the UNUSED ROOM - powered state
                                   //PLM index of 0
                                   //7C319
                                   //DB EE 2B 09 83 00
                                   
                                   
                                   //I found DB EE 9B 09 83 00 at 0x7C231 which is the roomstate before Phantoon is killed
                                   //8F 00 00 00 3B B6 at 0x7C4FF which is after Phantoon is killed
                                   //00 00 00 00 DB EE at 0x7C22D
                                   //1E 76 8D 00 DB EE at 0x7C433
                                   //DB EE 9B 09 83 00 at 0x7C231
                                   Address = 0x7C2FF,
                                   //Address = 0x7C22D,
                                   //Address = 0x7C4FF,
                                   //Address = 0x7C231,
                                   //	Address = 0x7C319,
                                   CanAccess =
                                       have => 
                                       CanAccessWs(have),
                               },
                           new Location
                               {                           
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Energy Tank (Wrecked Ship)",
                                   Address = 0x7C337,
                                   CanAccess =
                                       have => 
                                       CanAccessWs(have)
									   && have.Contains(ItemType.GrappleBeam),
                               },
                           new Location
                               {                            
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Super Missile (Wrecked Ship left)",
                                   Address = 0x7C357,
                                   CanAccess =
                                       have => 
                                       CanAccessWs(have),
                               },
                           new Location
                               {                           
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Super Missile (Wrecked Ship right)",
                                   Address = 0x7C365,
                                   CanAccess =
                                       have => 
                                       CanAccessWs(have),
                               },
                           new Location
                               {                           
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Gravity Suit",
                                   //Address = 0x7C36D, //project base
                                   //Address = 0x7C2EF, //original
                                   //I found 0B EF 07 29 87 00 at 0x78A86 default roomstate
                                   //Address = 0x78A86,
                                   //0B EF 07 29 87 00 at 0x78A86, THIS IS THE WINNER
                                   Address = 0x78A86,
                                   CanAccess =
                                       have => 
                                       CanAccessWs(have)
                                   	&& (have.Contains(ItemType.SpeedBooster)
                                   	|| have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpaceJump)), //none needed for speedrunner
                               },
							   
							new Location
                               {                           
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
								   //Map Missiles #3
                                   Name = "Missile (Wrecked Ship Map Station Missiles)",
                                   Address = 0x7C34D,
								   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have => 
                                       CanAccessWs(have)
                                   	&& have.Contains(ItemType.HiJumpBoots)
                                   	&& (have.Contains(ItemType.SpeedBooster)
                                   	|| have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpaceJump))
                                   	&& have.Contains(ItemType.IceBeam),

                               },   
                           new Location
                               {                           
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Maridia Main Street)",
								   //0x7C437
                                   //Address = 0x7C43D,
                                   Address = 0x7C437,
                                   CanAccess =
                                       have =>
                                   	CanAccessRedBrinstar(have)
                                   	&& have.Contains(ItemType.GravitySuit)
                                   	&& have.Contains(ItemType.SpeedBooster),
                                   	
                               },
                           new Location
                               {                             
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Super Missile (Maridia Crab Supers)",
                                   Address = 0x7C43D,
                                   CanAccess =
                                   		have =>
                                   	CanAccessMaridiaCasual(have),
                                       
                               },
                           new Location
                               {                             
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Energy Tank (Maridia Turtles)",
                                   Address = 0x7C47D,
                                   CanAccess =
                                       have =>
                                   	CanAccessMaridiaCasual(have)
                                   	&& (have.Contains(ItemType.SpaceJump)
                                   	|| have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpeedBooster))
                               },
                           new Location
                               {                            
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Maridia Turtles)",
                                   Address = 0x7C483,
                                   CanAccess =
                                       have =>
                                   	CanAccessMaridiaCasual(have),
                               },
                           new Location
                               {                             
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Super Missile (Maridia Watering Hole Supers)",
								   //0x7C4AF
                                   Address = 0x7F196,
                                   CanAccess =
                                       have =>
                                   	CanAccessMaridiaCasual(have)
                                   	&& have.Contains(ItemType.HiJumpBoots),
                               },
                           new Location
                               {                             
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Maridia Watering Hole Missiles)",
								   //0x7C4B5
                                   Address = 0x7F19C,
                                   CanAccess =
                                       have =>
                                   	CanAccessMaridiaCasual(have)
                                   	&& have.Contains(ItemType.HiJumpBoots),
                               },
                           new Location
                               {                             
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Maridia Beach Missiles)",
								   //0x7C533
                                   Address = 0x7C515,
                                   CanAccess =
                                       have =>
                                       CanAccessMaridiaCasual(have)
                                   	&& have.Contains(ItemType.HiJumpBoots),
                               },
                           new Location
                               {                             
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Plasma Beam",
                                   Address = 0x7C559,
                                   CanAccess =
                                       have =>
                                       CanAccessMaridiaCasual(have),
                               },
                           new Location
                               {                             
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Maridia left sand pit room)",
                                   //Address = 0x7C5DD,
                                   //Address = 0x7FECB,
                                   Address = 0x7FECB,
                                   CanAccess =
                                       have =>
                                   	CanAccessAquaductCasual(have),
                               },
                           new Location
                               {                            
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Reserve Tank (Maridia Reserves)",
                                   //Address = 0x7C5E3,
                                   //Address = 0x7FECA,
                                   Address = 0x7FEC5,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                   	CanAccessAquaductCasual(have),
                               },
                           new Location
                               {                           
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Maridia right sand pit room)",
                                   //Address = 0x7C5EB,
                                   Address = 0x7FED1,
                                   CanAccess =
                                       have =>
                                       CanAccessAquaductCasual(have),
                               },
                           new Location
                               {                            
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Power Bomb (Maridia right sand pit room)",
                                   //Address = 0x7C5F1,
                                   Address = 0x7FED7,
                                   CanAccess =
                                       have =>
                                       CanAccessAquaductCasual(have),
                               },
                           new Location
                               {                            
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Aqueduct Missiles)",
								   //0x7C603
                                   Address = 0x7FEB9,
                                   CanAccess =
                                       have =>
                                       CanAccessAquaductCasual(have)
                                   	&& have.Contains(ItemType.SpeedBooster),
                               },
                           new Location
                               {                             
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Super Missile (Aqueduct Supers)",
								   //0x7C609
                                   Address = 0x7FEBF,
                                   CanAccess =
                                       have =>
                                       CanAccessAquaductCasual(have)
                                   	&& have.Contains(ItemType.SpeedBooster),
                               },
                           new Location
                               {                             
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Spring Ball",
                                   Address = 0x7C6E5,
                                   CanAccess =
                                       have =>
                                   	CanAccessMaridiaCasual(have)
                                   	&& have.Contains(ItemType.SpaceJump),
                               },
                           new Location
                               {                            
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Draygon)",
                                   //Address = 0x7C74D,
                                   //could be 0x780CC OR 0x780D2
                                   Address = 0x780D2,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessAquaductCasual(have)
									   && have.Contains(ItemType.GrappleBeam),
                               },
                           new Location
                               {                             
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Energy Tank (Botwoon)",
								   //0x7C755
                                   Address = 0x7C79F,
                                   CanAccess =
                                       have =>
                                       CanAccessAquaductCasual(have)
                                   	&& have.Contains(ItemType.ChargeBeam),
                               },
                           new Location
                               {                            
                                   NoHidden = true,//ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Space Jump",
								   //0x7C7A7 is the original address
                                   //Address = 0x7EF40, is apparently the wrong address
                                   //neither addresses work???
                                   //Address = 0x7C7A7,
                                   Address = 0x7C791,
                                   CanAccess =
                                       have =>
                                       CanAccessAquaductCasual(have)
									   && have.Contains(ItemType.GrappleBeam),
                               },
							   new Location
                               {                             
                                   NoHidden = true, //ok
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
								   //Map Missiles #4
                                   Name = "Missile (Maridia Map Station Missiles - Corridor)",
                                   Address = 0x7C4B1,
                                   CanAccess =
                                       have =>
                                   	CanAccessRedBrinstar(have),
                               },
                       };
        }
         private static bool CanUsePowerBombs(List<ItemType> have)
        {
            return have.Contains(ItemType.PowerBomb) 
                && have.Contains(ItemType.MorphingBall);
		}
		private static bool CanAccessWs(List<ItemType> have)
        {
            return have.Contains(ItemType.SuperMissile) 
                && CanUsePowerBombs(have)
            	&& EnergyReserveCount(have) >= 6
                && (have.Contains(ItemType.SpaceJump) 
                    || have.Contains(ItemType.GrappleBeam) 
                    || have.Contains(ItemType.SpeedBooster));
		}
		
        private static bool CanEnterAndLeaveGauntlet(List<ItemType> have)
        {
            return (have.Contains(ItemType.SpeedBooster) 
				|| (have.Contains(ItemType.Bomb)
                    && have.Contains(ItemType.MorphingBall))
                || (have.Count(x => x == ItemType.PowerBomb) >= 2 
        	            && have.Contains(ItemType.MorphingBall))
        	        || (have.Contains(ItemType.ScrewAttack)
        	            && have.Contains(ItemType.HiJumpBoots)));
        }	
        private static bool CanOpenPassages(List<ItemType> have)
        {

			return (have.Contains(ItemType.MorphingBall)
				&& have.Contains(ItemType.Bomb))
				|| CanUsePowerBombs(have)
				|| have.Contains(ItemType.ScrewAttack);
		}
		
        private static bool CanEnterPassages(List<ItemType> have)
        {
			return (have.Contains(ItemType.MorphingBall)
				&& have.Contains(ItemType.Bomb))
				|| CanUsePowerBombs(have);
		}
		
        private static bool CanDestroyBombBlocks(List<ItemType> have)
        {
			return CanEnterPassages(have)
				|| (have.Contains(ItemType.ScrewAttack)
				    || have.Contains(ItemType.SpeedBooster));
		}
		
		private static bool CanSpeedball(List<ItemType> have)
		{
			return (have.Contains(ItemType.SpeedBooster)
				&& have.Contains(ItemType.MorphingBall));
		}

		private static bool CanOpenMissileDoors(List<ItemType> have)
		{
			return (have.Contains(ItemType.Missile)
				|| have.Contains(ItemType.SuperMissile));
		}
		private static bool CanAccessRedBrinstar(List<ItemType> have)
		{
			//3 possible routes to enter Red Brinstar
			return (have.Contains(ItemType.SuperMissile)
			        && CanUsePowerBombs(have))
							//Rightside blue brinstar now has yellow door instead of green
				|| CanUsePowerBombs(have)
							//backway to xray is now yellow door instead of green
				|| CanUsePowerBombs(have)
				    && have.Contains(ItemType.GrappleBeam);
		}		
		private static bool CanAccessGreenBrinstar(List<ItemType> have)
		{
			//5 possible routes to enter Green Brinstar
						//Intended entrance
			return CanEnterPassages(have) 
						//From Red Tower
				|| (CanUsePowerBombs(have)
				&& have.Contains(ItemType.SuperMissile)) 
						//From under first missiles leading to big pink
				|| (CanEnterPassages(have) 
				&& have.Contains(ItemType.SuperMissile))
						//Right side blue brinstar leading to red tower
				|| (CanOpenMissileDoors(have)
				&& CanUsePowerBombs(have)); 
						//another entrance near morph ball
				
		}
		private static bool CanAccessPinkBrinstar(List<ItemType> have)
		{
			//3 possible routes to enter Pink Brinstar
					//From under first missiles
			return CanEnterPassages(have)
				&& have.Contains(ItemType.SuperMissile)
					//Any of the 5 ways to access green brinstar
				|| (CanAccessGreenBrinstar(have)
				&& CanOpenMissileDoors(have))
					//any of the 3 ways to access red brinstar
				|| CanAccessRedBrinstar(have);
		}			        
		
		private static bool CanDefeatKraid(List<ItemType> have)
		{
			return CanAccessRedBrinstar(have)
				&& CanEnterPassages(have)
				&& CanOpenMissileDoors(have)
				&& EnergyReserveCount(have) >= 3;
		}
		
		private static bool CanAccessHeatedNorfair(List<ItemType> have)
		{
			return CanAccessRedBrinstar(have)
			&& (have.Contains(ItemType.VariaSuit)
				|| have.Contains(ItemType.GravitySuit));
		}
		private static bool CanAccessIceBeam(List<ItemType> have)
		{
			return CanAccessHeatedNorfair(have) 
				    && CanUsePowerBombs(have);
		}	
		private static bool CanAccessCrocomire(List<ItemType> have)
		{
			return CanAccessHeatedNorfair(have)
					&& have.Contains(ItemType.SuperMissile);
		}	
		private static bool CanAccessLowerNorfair(List<ItemType> have)
		{
			return CanAccessHeatedNorfair(have)
				&& have.Contains(ItemType.ChargeBeam)
				&& EnergyReserveCount(have) >= 8
				&& ((have.Contains(ItemType.GravitySuit) //Route 1 - normal entrance
				    && have.Contains(ItemType.SpaceJump)) //can do lava dive, gravity jump||lava spark w/gravity
				    || (CanEnterPassages(have)));//backdoor method
		}	
		private static bool CanAccessMaridiaCasual(List<ItemType> have)
		{
			return CanAccessRedBrinstar(have)
				&& have.Contains(ItemType.GravitySuit)
				&& EnergyReserveCount(have) >= 8
				&& CanUsePowerBombs(have);
		}	
		
		private static bool CanAccessAquaductCasual(List<ItemType> have)
		{
			return CanAccessMaridiaCasual(have)
				&& have.Contains(ItemType.ChargeBeam)
				&& (have.Contains(ItemType.SpeedBooster)
				|| have.Contains(ItemType.SpaceJump)
				|| have.Contains(ItemType.GrappleBeam));
		}	
		
        private static int EnergyReserveCount(List<ItemType> have)
        {
            var energyTankCount = have.Count(x => x == ItemType.EnergyTank);
            var reserveTankCount = Math.Min(have.Count(x => x == ItemType.ReserveTank), energyTankCount + 1);
            return energyTankCount + reserveTankCount;
        }
		private static bool CanMeetEtecoons(List<ItemType> have)
		{
			return CanAccessGreenBrinstar(have)
				&& CanUsePowerBombs(have);
		}	
        public RomLocationsCasual()
        {
            ResetLocations();
        }

        public List<Location> GetAvailableLocations(List<ItemType> haveItems)
        {
            var retVal = (from Location location in Locations where (location.Item == null) && location.CanAccess(haveItems) select location).ToList();
            var currentWeight = (from item in retVal orderby item.Weight descending select item.Weight).First() + 1;

            foreach (var item in retVal.Where(item => item.Weight == 0))
            {
                item.Weight = currentWeight;
            }

            var addedItems = new List<List<Location>>();
            for (int i = 1; i < currentWeight; i++)
            {
                addedItems.Add(retVal.Where(x => x.Weight > i).ToList());
            }

            foreach (var list in addedItems)
            {
                retVal.AddRange(list);
            }

            return retVal;
        }

        public List<Location> GetUnavailableLocations(List<ItemType> haveItems)
        {
            return (from Location location in Locations where location.Item == null && !location.CanAccess(haveItems) select location).ToList();
        }

        public void TryInsertCandidateItem(List<Location> currentLocations, List<ItemType> candidateItemList, ItemType candidateItem)
        {
			// only try gravity if gravity is okay in this spot
			// only insert multiples of an item into the candidate list if we aren't looking at the morph ball slot.
			if (currentLocations.All(x => x.Name != "Morphing Ball") || !candidateItemList.Contains(candidateItem))
            {
                candidateItemList.Add(candidateItem);
            }
        }

        public int GetInsertedLocation(List<Location> currentLocations, ItemType insertedItem, SeedRandom random)
        {
            return random.Next(currentLocations.Count);
        }

        public ItemType GetInsertedItem(List<Location> currentLocations, List<ItemType> itemPool, SeedRandom random)
        {
            return itemPool[random.Next(itemPool.Count)];
        }

        public List<ItemType> GetItemPool(SeedRandom random)
        {
            return new List<ItemType>
                       {
            	//all items - 1 charge beam
            	//can replace the charge beam with a bunch of missiles and stuff
            	//I still consider having more than 1 charge beam
                           ItemType.MorphingBall,
                           ItemType.Bomb,
                           ItemType.ChargeBeam,
                           ItemType.Spazer,
                           ItemType.VariaSuit,
                           ItemType.HiJumpBoots,
                           ItemType.SpeedBooster,
                           ItemType.WaveBeam,
                           ItemType.GrappleBeam,
                           ItemType.GravitySuit,
                           ItemType.SpaceJump,
                           ItemType.SpringBall,
                           ItemType.PlasmaBeam,
                           ItemType.IceBeam,
                           ItemType.ScrewAttack,
                           ItemType.XRayScope,
                           ItemType.ReserveTank,
                           ItemType.ReserveTank,
                           ItemType.ReserveTank,
                           ItemType.ReserveTank,
                           ItemType.Missile,
						   ItemType.Missile,
                           ItemType.Missile,
						   ItemType.Missile,
						   ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           //104%
                       };
        }
    }
}
