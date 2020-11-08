-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.33


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema bko
--

CREATE DATABASE IF NOT EXISTS bko;
USE bko;

--
-- Definition of table `AKT_SP_OS3`
--

DROP TABLE IF EXISTS `AKT_SP_OS3`;
CREATE TABLE `AKT_SP_OS3` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_COMP` int(11) DEFAULT '0',
  `DATAV` datetime DEFAULT NULL,
  `KOMPL` varchar(255) DEFAULT NULL,
  `Model` varchar(255) DEFAULT NULL,
  `GODPR` int(11) DEFAULT '0',
  `DATAPOST` datetime DEFAULT NULL,
  `STOIM` decimal(19,4) DEFAULT '0.0000',
  `Nomer` int(11) DEFAULT '0',
  `KolvoRem` int(11) DEFAULT '0',
  `DATAPK` datetime DEFAULT NULL,
  `opis` text,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `ID_COMP` (`ID_COMP`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `AKT_SP_OS3`
--

/*!40000 ALTER TABLE `AKT_SP_OS3` DISABLE KEYS */;
/*!40000 ALTER TABLE `AKT_SP_OS3` ENABLE KEYS */;


--
-- Definition of table `ActOS`
--

DROP TABLE IF EXISTS `ActOS`;
CREATE TABLE `ActOS` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nomer` varchar(50) NOT NULL,
  `tiporgtex` varchar(50) DEFAULT NULL,
  `otdel` varchar(50) DEFAULT NULL,
  `computer` varchar(50) DEFAULT NULL,
  `cena` varchar(50) DEFAULT NULL,
  `invent` varchar(50) DEFAULT NULL,
  `dataprikaza` datetime DEFAULT NULL,
  `NomerPrikaza` varchar(50) DEFAULT NULL,
  `modTexn` varchar(255) DEFAULT NULL,
  `postavshik` varchar(100) DEFAULT NULL,
  `godVipuska` varchar(50) DEFAULT NULL,
  `datasost` datetime DEFAULT NULL,
  `Filial` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `ActOS`
--

/*!40000 ALTER TABLE `ActOS` DISABLE KEYS */;
/*!40000 ALTER TABLE `ActOS` ENABLE KEYS */;


--
-- Definition of table `CARTRIDG`
--

DROP TABLE IF EXISTS `CARTRIDG`;
CREATE TABLE `CARTRIDG` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SN` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT NULL,
  `TIP` varchar(255) DEFAULT NULL,
  `Model` int(11) DEFAULT NULL,
  `USTR` int(11) DEFAULT NULL,
  `PROD` int(11) DEFAULT NULL,
  `SCHET` varchar(255) DEFAULT NULL,
  `Cena` int(11) DEFAULT NULL,
  `DATA` datetime DEFAULT NULL,
  `PRIM` text,
  `NZap` tinyint(4) DEFAULT '0',
  `NeZap` tinyint(4) DEFAULT '0',
  `Iznos` tinyint(4) DEFAULT '0',
  `Spisan` tinyint(4) DEFAULT '0',
  `NaSpisanie` tinyint(4) DEFAULT '0',
  `PREF` int(11) DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `CARTRIDG`
--

/*!40000 ALTER TABLE `CARTRIDG` DISABLE KEYS */;
/*!40000 ALTER TABLE `CARTRIDG` ENABLE KEYS */;


--
-- Definition of table `CARTRIDG_D`
--

DROP TABLE IF EXISTS `CARTRIDG_D`;
CREATE TABLE `CARTRIDG_D` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Comp` int(11) DEFAULT '0',
  `oldMesto` varchar(255) DEFAULT NULL,
  `NewMesto` varchar(255) DEFAULT NULL,
  `Prich` text,
  `data` datetime DEFAULT NULL,
  `time` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `CARTRIDG_D`
--

/*!40000 ALTER TABLE `CARTRIDG_D` DISABLE KEYS */;
/*!40000 ALTER TABLE `CARTRIDG_D` ENABLE KEYS */;


--
-- Definition of table `CARTRIDG_Z`
--

DROP TABLE IF EXISTS `CARTRIDG_Z`;
CREATE TABLE `CARTRIDG_Z` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ID_C` int(11) DEFAULT NULL,
  `Z_N` int(11) DEFAULT NULL,
  `SC` int(11) DEFAULT NULL,
  `AKTVR` varchar(255) DEFAULT NULL,
  `DATAAKT` datetime DEFAULT NULL,
  `STOIM` varchar(255) DEFAULT NULL,
  `DATAZAP` datetime DEFAULT NULL,
  `VOST` tinyint(4) DEFAULT '0',
  `Paper` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `CARTRIDG_Z`
--

/*!40000 ALTER TABLE `CARTRIDG_Z` DISABLE KEYS */;
/*!40000 ALTER TABLE `CARTRIDG_Z` ENABLE KEYS */;


--
-- Definition of table `CONFIGURE`
--

DROP TABLE IF EXISTS `CONFIGURE`;
CREATE TABLE `CONFIGURE` (
  `Name_Prog` varchar(255) DEFAULT NULL,
  `SISADM` varchar(255) DEFAULT NULL,
  `ORG` varchar(255) DEFAULT NULL,
  `NR` varchar(255) DEFAULT NULL,
  `Nomer_Compa` varchar(255) DEFAULT NULL,
  `asc` tinyint(4) DEFAULT '0',
  `access` varchar(255) DEFAULT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `CONFIGURE`
--

/*!40000 ALTER TABLE `CONFIGURE` DISABLE KEYS */;
INSERT INTO `CONFIGURE` (`Name_Prog`,`SISADM`,`ORG`,`NR`,`Nomer_Compa`,`asc`,`access`,`id`) VALUES 
 ('BKO.NET','SISADM','BKO.SHATKI.INFO','Yes',NULL,0,'1.7.3.9',2);
/*!40000 ALTER TABLE `CONFIGURE` ENABLE KEYS */;


--
-- Definition of table `Garantia_sis`
--

DROP TABLE IF EXISTS `Garantia_sis`;
CREATE TABLE `Garantia_sis` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Comp` int(11) DEFAULT '0',
  `Postav` varchar(50) DEFAULT NULL,
  `Day` varchar(50) DEFAULT NULL,
  `Month` varchar(50) DEFAULT NULL,
  `Year` varchar(50) DEFAULT NULL,
  `Day_O` varchar(50) DEFAULT NULL,
  `Month_O` varchar(50) DEFAULT NULL,
  `Year_O` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Id` (`Id`),
  KEY `Id_Comp` (`Id_Comp`)
) ENGINE=InnoDB AUTO_INCREMENT=318 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `Garantia_sis`
--

/*!40000 ALTER TABLE `Garantia_sis` DISABLE KEYS */;
/*!40000 ALTER TABLE `Garantia_sis` ENABLE KEYS */;


--
-- Definition of table `OTD_O`
--

DROP TABLE IF EXISTS `OTD_O`;
CREATE TABLE `OTD_O` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Id_OTD` varchar(50) DEFAULT NULL,
  `Phone` varchar(50) DEFAULT NULL,
  `OTV` varchar(50) DEFAULT NULL,
  `ADRESS` varchar(50) DEFAULT NULL,
  `Prim` text,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `OTD_O`
--

/*!40000 ALTER TABLE `OTD_O` DISABLE KEYS */;
/*!40000 ALTER TABLE `OTD_O` ENABLE KEYS */;


--
-- Definition of table `PCI`
--

DROP TABLE IF EXISTS `PCI`;
CREATE TABLE `PCI` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Comp` int(11) DEFAULT '0',
  `PCI` varchar(255) DEFAULT NULL,
  `PCI_SN` varchar(255) DEFAULT NULL,
  `PCI_PROIZV` varchar(255) DEFAULT NULL,
  `PCI_NOMER` int(11) DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `PCI`
--

/*!40000 ALTER TABLE `PCI` DISABLE KEYS */;
/*!40000 ALTER TABLE `PCI` ENABLE KEYS */;


--
-- Definition of table `Remont`
--

DROP TABLE IF EXISTS `Remont`;
CREATE TABLE `Remont` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Date` datetime DEFAULT NULL,
  `Id_Comp` int(11) DEFAULT '0',
  `Remont` text,
  `Uroven` varchar(50) DEFAULT NULL,
  `Master` varchar(50) DEFAULT NULL,
  `NomerRemKomp` varchar(50) DEFAULT NULL,
  `Comp_Name` varchar(50) DEFAULT NULL,
  `Mesto_Compa` varchar(255) DEFAULT NULL,
  `vip` varchar(50) DEFAULT NULL,
  `UserName` varchar(255) DEFAULT NULL,
  `GARANT` datetime DEFAULT NULL,
  `istochnik` varchar(50) DEFAULT NULL,
  `phone` varchar(50) DEFAULT NULL,
  `srok` datetime DEFAULT NULL,
  `name_of_remont` varchar(50) DEFAULT NULL,
  `otvetstv` varchar(50) DEFAULT NULL,
  `krit_rem` varchar(50) DEFAULT NULL,
  `MeMo` text,
  `zakryt` tinyint(4) DEFAULT '0',
  `PREF` varchar(5) DEFAULT NULL,
  `Summ` decimal(19,4) DEFAULT '0.0000',
  `starttime` datetime DEFAULT NULL,
  `stoptime` datetime DEFAULT NULL,
  `startdate` datetime DEFAULT NULL,
  `stopdate` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Id` (`Id`),
  KEY `Master` (`Master`),
  KEY `Uroven` (`Uroven`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `Remont`
--

/*!40000 ALTER TABLE `Remont` DISABLE KEYS */;
/*!40000 ALTER TABLE `Remont` ENABLE KEYS */;


--
-- Definition of table `SES_Pass`
--

DROP TABLE IF EXISTS `SES_Pass`;
CREATE TABLE `SES_Pass` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Ploshad` varchar(50) DEFAULT NULL,
  `visota` varchar(50) DEFAULT NULL,
  `Pl1Pk` varchar(50) DEFAULT NULL,
  `ob1Pk` varchar(50) DEFAULT NULL,
  `nalpom` varchar(50) DEFAULT NULL,
  `vent` varchar(50) DEFAULT NULL,
  `teplo` varchar(50) DEFAULT NULL,
  `voda` varchar(50) DEFAULT NULL,
  `kanal` varchar(50) DEFAULT NULL,
  `otdelka` text,
  `mebel` text,
  `id_OF` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SES_Pass`
--

/*!40000 ALTER TABLE `SES_Pass` DISABLE KEYS */;
/*!40000 ALTER TABLE `SES_Pass` ENABLE KEYS */;


--
-- Definition of table `SOFT_INSTALL`
--

DROP TABLE IF EXISTS `SOFT_INSTALL`;
CREATE TABLE `SOFT_INSTALL` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Comp` int(11) DEFAULT '0',
  `Soft` varchar(255) DEFAULT NULL,
  `NomerSoftKomp` int(11) DEFAULT '0',
  `t_lic` varchar(255) DEFAULT NULL,
  `L_key` varchar(255) DEFAULT NULL,
  `d_p` datetime DEFAULT NULL,
  `d_o` datetime DEFAULT NULL,
  `Publisher` text,
  `TIP` text,
  PRIMARY KEY (`Id`),
  KEY `Id_Comp` (`Id_Comp`),
  KEY `Id` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4172 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SOFT_INSTALL`
--

/*!40000 ALTER TABLE `SOFT_INSTALL` DISABLE KEYS */;
INSERT INTO `SOFT_INSTALL` (`Id`,`Id_Comp`,`Soft`,`NomerSoftKomp`,`t_lic`,`L_key`,`d_p`,`d_o`,`Publisher`,`TIP`) VALUES 
 (3928,147,'Îëèìïèàäà Ñìåøàðèêîâ 1,0',1,'','','0000-00-00 00:00:00','2004-03-20 14:00:00','NoName',''),
 (3929,147,'101 ëþáèì÷èê, Çàáàâíûå êîòÿòà',2,'','','0000-00-00 00:00:00','2004-03-20 14:00:00','ÎÎÎ ËÈÃÀ ÇÀÊÎÍ',''),
 (3930,147,'7-Zip 9,20',3,'','','0000-00-00 00:00:00','2004-03-20 14:00:00','NoName',''),
 (3931,147,'ABBYY FineReader11 Professional Edition',4,'','','0000-00-00 00:00:00','2004-03-20 14:00:00','ÎÎÎ ËÈÃÀ ÇÀÊÎÍ',''),
 (3932,147,'Adobe Flash Player 11 ActiveX',5,'','','0000-00-00 00:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3933,147,'Adobe Flash Player 11 Plugin',6,'','','0000-00-00 00:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3934,147,'Adobe Photoshop CS4',207,'','','0000-00-00 00:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3935,147,'Advanced Office Password Recovery (remove only)',8,'','','0000-00-00 00:00:00','2004-03-20 14:00:00','Elcomsoft Co.Ltd.',''),
 (3936,147,'AkelPad 4,6,5',9,'','','0000-00-00 00:00:00','2004-03-20 14:00:00','NoName',''),
 (3937,147,'Ashampoo Burning Studio 9 BETA',10,'','','2017-11-20 11:00:00','2004-03-20 14:00:00','ashampoo GmbH & Co. KG',''),
 (3938,147,'BitComet 1,34 64-bit',11,'','','2017-11-20 11:00:00','2004-03-20 14:00:00','CometNetwork',''),
 (3939,147,'Canon RAW Codec',12,'','','2017-11-20 11:00:00','2004-03-20 14:00:00','Canon Inc.',''),
 (3940,147,'DAEMON Tools Lite',13,'','','2017-11-20 11:00:00','2004-03-20 14:00:00','DT Soft Ltd',''),
 (3941,147,'Canon Utilities Digital Photo Professional',14,'','','2017-11-20 11:00:00','2004-03-20 14:00:00','Canon Inc.',''),
 (3942,147,'Microsoft Office Enterprise 2007',157,'','','2017-11-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (3943,147,'Canon Utilities EOS Utility',16,'','','2017-11-20 11:00:00','2004-03-20 14:00:00','Canon Inc.',''),
 (3944,147,'EVEREST Corporate Edition NR v5,50',17,'','','2031-07-20 12:00:00','2004-03-20 14:00:00','Lavalys, Inc.',''),
 (3945,147,'Fallout 3 v1,0',18,'','','2027-12-20 11:00:00','2004-03-20 14:00:00','NoName',''),
 (3946,147,'Git version 1,7,6-preview20110708',19,'','','2015-09-20 11:00:00','2004-03-20 14:00:00','NoName',''),
 (3947,147,'Google Chrome',20,'','','2006-10-20 12:00:00','2004-03-20 14:00:00','Google Inc.',''),
 (3948,147,'HM NIS Edit 2,0,3',21,'','','2006-10-20 12:00:00','2004-03-20 14:00:00','Hector Maurcio Rodriguez Segura',''),
 (3949,147,'SmartSound Quicktracks 5',80,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','SmartSound Software Inc.',''),
 (3950,147,'SmartSound Common Data',196,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','SmartSound Software Inc.',''),
 (3951,147,'IrfanView (remove only)',24,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Irfan Skiljan',''),
 (3952,147,'K-Lite Codec Pack 5,2,0 (Standard)',25,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','NoName',''),
 (3953,147,'LG PC Suite IV',26,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','LG Electronics',''),
 (3954,147,'Madagascar - Escape 2 Africa',27,'','','2031-07-20 12:00:00','2004-03-20 14:00:00','NoName',''),
 (3955,147,'Microsoft Visual Studio 2010 Professional - RUS',28,'','','2031-07-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (3956,147,'Microsoft Visual Studio Macro Tools',110,'','','2031-07-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (3957,147,'Microsoft Visual Studio Macro Tools - RUS Language Pack',72,'','','2031-07-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (3958,147,'Mozilla Firefox 21,0 (x86 ru)',31,'','','2031-07-20 12:00:00','2004-03-20 14:00:00','Mozilla',''),
 (3959,147,'Mozilla Thunderbird 17,0,6 (x86 ru)',32,'','','2031-07-20 12:00:00','2004-03-20 14:00:00','Mozilla',''),
 (3960,147,'Mozilla Maintenance Service',33,'','','2031-07-20 12:00:00','2004-03-20 14:00:00','Mozilla',''),
 (3961,147,'MS Access to MySQL 2,0,0,64',34,'','','2013-01-20 13:00:00','2004-03-20 14:00:00','Bullzip',''),
 (3962,147,'Need For Speed,Most Wanted 2012,Limited Edition,v 1,3,0,0 + 5 DLC',35,'','','2002-02-20 13:00:00','2004-03-20 14:00:00','Repack by Fenixx (22.12.2012)',''),
 (3963,147,'Nullsoft Install System',36,'','','2002-02-20 13:00:00','2004-03-20 14:00:00','NoName',''),
 (3964,147,'NVIDIA Stereoscopic 3D Driver',37,'','','2002-02-20 13:00:00','2004-03-20 14:00:00','NVIDIA Corporation',''),
 (3965,147,'OpenAL',38,'','','2002-02-20 13:00:00','2004-03-20 14:00:00','NoName',''),
 (3966,147,'pgAgent 3,3,0',39,'','','2002-02-20 13:00:00','2004-03-20 14:00:00','EnterpriseDB',''),
 (3967,147,'ÔÎÒÎ ÍÀ ÄÎÊÓÌÅÍÒÛ 4,02',40,'','','2013-09-20 11:00:00','2004-03-20 14:00:00','NoName',''),
 (3968,147,'Canon Utilities Picture Style Editor',41,'','','2013-09-20 11:00:00','2004-03-20 14:00:00','Canon Inc.',''),
 (3969,147,'Psi+',42,'','','2013-09-20 11:00:00','2004-03-20 14:00:00','Psi+ Project',''),
 (3970,147,'psqlODBC 09,01,0100',43,'','','2013-09-20 11:00:00','2004-03-20 14:00:00','EnterpriseDB',''),
 (3971,147,'Punch! Home Design - Platinum',44,'','','2013-09-20 11:00:00','2004-03-20 14:00:00','NoName',''),
 (3972,147,'PuTTY version 0,61',45,'','','2013-09-20 11:00:00','2004-03-20 14:00:00','Simon Tatham',''),
 (3973,147,'Samsung Universal Print Driver',46,'','','2013-09-20 11:00:00','2004-03-20 14:00:00','Samsung Electronics CO.,LTD',''),
 (3974,147,'Samsung Universal Scan Driver',47,'','','2013-09-20 11:00:00','2004-03-20 14:00:00','Samsung Electronics Co., Ltd.',''),
 (3975,147,'Setup Last',48,'','','2024-02-20 13:00:00','2004-03-20 14:00:00','Setup',''),
 (3976,147,'SkyDNS Agent 2,3',49,'','','2024-02-20 13:00:00','2004-03-20 14:00:00','SkyDNS',''),
 (3977,147,'SumatraPDF',50,'','','2024-09-20 12:00:00','2004-03-20 14:00:00','Krzysztof Kowalczyk',''),
 (3978,147,'Total Commander (Remove or Repair)',51,'','','2024-09-20 12:00:00','2004-03-20 14:00:00','Ghisler Software GmbH',''),
 (3979,147,'TweakNow RegCleaner',52,'','','2016-02-20 13:00:00','2004-03-20 14:00:00','TweakNow.com',''),
 (3980,147,'VLC media player 2,0,1',53,'','','2016-02-20 13:00:00','2004-03-20 14:00:00','VideoLAN',''),
 (3981,147,'Windows Media Encoder 9 Series',206,'','','2016-02-20 13:00:00','2004-03-20 14:00:00','NoName',''),
 (3982,147,'Windows Media Player Last',55,'','','2025-06-20 13:00:00','2004-03-20 14:00:00','Windows Media Player',''),
 (3983,147,'Windows Media Lite 2,4,0',56,'','','2025-06-20 13:00:00','2004-03-20 14:00:00','NoName',''),
 (3984,147,'Corel VideoStudio Pro X5',57,'','','2025-06-20 13:00:00','2004-03-20 14:00:00','Corel Corporation',''),
 (3985,147,'Microsoft Games for Windows - LIVE Redistributable',58,'','','2027-12-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (3986,147,'Adobe Update Manager CS4',59,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3987,147,'Òà÷êè, Íîâûé ñåçîí [RUS]',60,'','','2021-06-20 13:00:00','2004-03-20 14:00:00','R.G. ReCoding - by Donald Dark , Inc.',''),
 (3988,147,'Ñèñòåìíûå òèïû Microsoft SQL Server System CLR Types',61,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (3989,147,'kuler',62,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3990,147,'Adobe Color NA Extra Settings CS4',63,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3991,147,'Adobe Color JA Extra Settings CS4',64,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3992,147,'Adobe Setup',65,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3993,147,'Adobe Color EU Recommended Settings CS4',66,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3994,147,'JetBrains ReSharper 7,1,2',67,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','JetBrains Inc',''),
 (3995,147,'Adobe CSI CS4',68,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3996,147,'Readiris Pro 10',69,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','NoName',''),
 (3997,147,'Adobe Anchor Service CS4',70,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3998,147,'AdobeColorCommonSetRGB',71,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (3999,147,'Microsoft ,NET Framework 4,5 SDK',73,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4000,147,'ICA',74,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Corel Corporation',''),
 (4001,147,'Dr,Web Security Space 7,0',75,'','','2021-03-20 12:00:00','2004-03-20 14:00:00','ÎÎÎ \"Äîêòîð Âåá\"',''),
 (4002,147,'Office Tab Enterprise',76,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Detong Technology Ltd.',''),
 (4003,147,'Microsoft Visual C++ 2008 Redistributable - x86 9,0,30729,4148',77,'','','2020-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4004,147,'Visual Studio 2010 Tools for SQL Server Compact 3,5 SP2 RUS',78,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4005,147,'LibreOffice 4,0,2,1',79,'','','2019-03-20 13:00:00','2004-03-20 14:00:00','The Document Foundation',''),
 (4006,147,'Components Setup',81,'','','2011-01-20 12:00:00','2004-03-20 14:00:00','Vimicro Corporation',''),
 (4007,147,'PDF Settings CS4',82,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4008,147,'MySQL Connector/ODBC 5,1',83,'','','2026-04-20 13:00:00','2004-03-20 14:00:00','Oracle Corporation',''),
 (4009,147,'Adobe XMP Panels CS4',84,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4010,147,'WCF RIA Services V1,0 SP2',85,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4011,147,'Adobe Color - Photoshop Specific CS4',86,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4012,147,'Adobe WinSoft Linguistics Plugin',87,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4013,147,'Entity Framework Designer äëÿ Visual Studio 2012 - RUS',88,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4014,147,'Microsoft SQL Server Data Tools - RUS (11,1,20627,00)',89,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4015,147,'PrintHelp, âåðñèÿ 3,0,1,1',90,'','','2026-02-20 13:00:00','2004-03-20 14:00:00','OOO SUPERPRINT',''),
 (4016,147,'Microsoft Sync Framework SDK v1,0 SP1 ru',91,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4017,147,'Adobe Service Manager Extension',92,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4018,147,'Microsoft SQL Server Compact 3,5 SP2 RUS',93,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4019,147,'Microsoft SQL Server Data Tools Build Utilities - RUS (11,1,20627,00)',94,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4020,147,'Skype™ 6,1',95,'','','2014-02-20 13:00:00','2004-03-20 14:00:00','Skype Technologies S.A.',''),
 (4021,147,'ASUSUpdate',96,'','','2014-02-20 13:00:00','2004-03-20 14:00:00','NoName',''),
 (4022,147,'VSPro',97,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Corel Corporation',''),
 (4023,147,'Microsoft ,NET Framework 4,5 Multi-Targeting Pack',98,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4024,147,'ßçûêîâîé ïàêåò äëÿ ñðåäñòâà ïðîñìîòðà ñïðàâêè (Microsoft) 2,0 - RUS',218,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4025,147,'Îáúåêòû SMO Microsoft SQL Server 2008 R2',100,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4026,147,'Òà÷êè, Âåñåëûå ãîíêè [RUS]',101,'','','2020-06-20 13:00:00','2004-03-20 14:00:00','R.G. ReCoding - by Donald Dark , Inc.',''),
 (4027,147,'Microsoft Visual Studio 2010 ADO,NET Entity Framework Tools',102,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4028,147,'Microsoft ASP,NET Web Pages',103,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4029,147,'Adobe Color Video Profiles CS CS4',104,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4030,147,'Adobe Photoshop CS4 Support',105,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4031,147,'IPM_VS_Pro',106,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Corel Corporation',''),
 (4032,147,'AdobeColorCommonSetCMYK',107,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4033,147,'VSHelp',108,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Corel Corporation',''),
 (4034,147,'Microsoft Visual C++ 2010  x86 Runtime - 10,0,30319',109,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4035,147,'MSXML 4,0 SP2 Parser and SDK',111,'','','2007-10-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4036,147,'Microsoft Visual C++ 2005 Redistributable',118,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4037,147,'Microsoft SQL Server 2008 R2 Transact-SQL Language Service',113,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4038,147,'MySQL Connector/ODBC 3,51',114,'','','2031-10-20 11:00:00','2004-03-20 14:00:00','Oracle Corporation',''),
 (4039,147,'Microsoft ,NET Framework 4,5 SDK - ðóññêèé ÿçûêîâîé ïàêåò',115,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4040,147,'Rosetta Stone Version 3',116,'','','2006-04-20 12:00:00','2004-03-20 14:00:00','Rosetta Stone Ltd.',''),
 (4041,147,'Adobe Type Support CS4',117,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4042,147,'Adobe Bridge CS4',119,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4043,147,'psqlODBC',120,'','','2031-01-20 13:00:00','2004-03-20 14:00:00','PostgreSQL Global Development Group',''),
 (4044,147,'Microsoft System CLR Types äëÿ SQL Server 2012',121,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4045,147,'Suite Shared Configuration CS4',122,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4046,147,'Rosetta Stone Version 3 Ðóñèôèêàòîð',123,'','','2006-04-20 12:00:00','2004-03-20 14:00:00','MobyArt',''),
 (4047,147,'MSXML 4,0 SP2 (KB954430)',124,'','','2027-09-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4048,147,'Microsoft ASP,NET MVC 3 - RUS',125,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4049,147,'Microsoft Silverlight',126,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4050,147,'VSClassic',127,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Corel Corporation',''),
 (4051,147,'NVIDIA PhysX',128,'','','2016-02-20 13:00:00','2004-03-20 14:00:00','NVIDIA Corporation',''),
 (4052,147,'Microsoft Office Access MUI (Russian) 2007',129,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4053,147,'2007 Microsoft Office Suite Service Pack 3 (SP3)',176,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4054,147,'Microsoft Office Excel MUI (Russian) 2007',131,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4055,147,'Microsoft Office Excel 2007 Help Îáíîâëåíèå (KB963678)',133,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4056,147,'Microsoft Office PowerPoint MUI (Russian) 2007',134,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4057,147,'Microsoft Office Powerpoint 2007 Help Îáíîâëåíèå (KB963669)',136,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4058,147,'Microsoft Office Publisher MUI (Russian) 2007',137,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4059,147,'Microsoft Office Outlook MUI (Russian) 2007',139,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4060,147,'Microsoft Office Outlook 2007 Help Îáíîâëåíèå (KB963677)',141,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4061,147,'Microsoft Office Word MUI (Russian) 2007',142,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4062,147,'Microsoft Office Word 2007 Help Îáíîâëåíèå (KB963665)',144,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4063,147,'Microsoft Office Proof (German) 2007',145,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4064,147,'Microsoft Office Proof (English) 2007',147,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4065,147,'Microsoft Office Proof (Russian) 2007',149,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4066,147,'Microsoft Office Proof (Ukrainian) 2007',151,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4067,147,'Ïàêåò îáåñïå÷åíèÿ ñîâìåñòèìîñòè äëÿ âûïóñêà 2007 ñèñòåìû Microsoft Office',153,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4068,147,'Microsoft Office Proofing (Russian) 2007',156,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4069,147,'Security Update for Microsoft Office PowerPoint 2007 (KB2596912) 32-Bit Edition',158,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4070,147,'Update for Microsoft Office 2007 suites (KB2596686) 32-Bit Edition',159,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4071,147,'Update for Microsoft Office Excel 2007 (KB2596596) 32-Bit Edition',160,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4072,147,'Security Update for Microsoft Office Publisher 2007 (KB2596705) 32-Bit Edition',161,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4073,147,'Security Update for Microsoft Office 2007 suites (KB2596785) 32-Bit Edition',163,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4074,147,'Security Update for Microsoft Office PowerPoint 2007 (KB2596764) 32-Bit Edition',164,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4075,147,'Update for Microsoft Office 2007 suites (KB2596651) 32-Bit Edition',165,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4076,147,'Update for Microsoft Office 2007 suites (KB2596789) 32-Bit Edition',166,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4077,147,'Update for 2007 Microsoft Office System (KB967642)',167,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft',''),
 (4078,147,'Microsoft Office InfoPath MUI (Russian) 2007',168,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4079,147,'Microsoft Office Shared MUI (Russian) 2007',170,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4080,147,'Microsoft Office OneNote MUI (Russian) 2007',172,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4081,147,'Microsoft Office 2003 Web Components',174,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4082,147,'Microsoft Office Groove MUI (Russian) 2007',175,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4083,147,'Microsoft Office File Validation Add-In',177,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4084,147,'SmarThru 4',178,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','NoName',''),
 (4085,147,'Adobe Linguistics CS4',179,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4086,147,'Adobe CMaps CS4',180,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4087,147,'Microsoft SQL Server 2008 R2 Data-Tier Application Project',181,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4088,147,'Microsoft Visual C++ 2008 Redistributable - x86 9,0,30729,17',182,'','','2003-10-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4089,147,'Microsoft ASP,NET Web Pages - RUS',183,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4090,147,'Microsoft Games for Windows - LIVE',184,'','','2027-12-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4091,147,'Setup',185,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Corel Corporation',''),
 (4092,147,'Google Update Helper',186,'','','2011-05-20 13:00:00','2004-03-20 14:00:00','Google Inc.',''),
 (4093,147,'Crystal Reports for Visual Studio',187,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','SAP',''),
 (4094,147,'Microsoft SQL Server Database Publishing Wizard 1,4',188,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4095,147,'Connect',189,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4096,147,'Epson Easy Photo Print Plug-in for PMB(Picture Motion Browser)',190,'','','2020-07-20 11:00:00','2004-03-20 14:00:00','SEIKO EPSON CORPORATION',''),
 (4097,147,'Ïëàòô, ïðèëîæ, óðîâíÿ äàííûõ äëÿ Microsoft SQL Server 2008 R2',191,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4098,147,'UBitMenu RU',192,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','UBit Schweiz AG',''),
 (4099,147,'Skype Click to Call',194,'','','2009-03-20 12:00:00','2004-03-20 14:00:00','Skype Technologies S.A.',''),
 (4100,147,'Microsoft Visual C++ 2008 Redistributable - x86 9,0,30729,4974',195,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4101,147,'Adobe Output Module',197,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4102,147,'Adobe Default Language CS4',198,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4103,147,'Íåîáõîäèìûå êîìïîíåíòû äëÿ SSDT',199,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','NoName',''),
 (4104,147,'Contents',200,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Corel Corporation',''),
 (4105,147,'EOSInfo',201,'','','2006-07-20 12:00:00','2004-03-20 14:00:00','astrojargon.net',''),
 (4106,147,'Photoshop Camera Raw',202,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4107,147,'Microsoft ,NET Framework 4 Multi-Targeting Pack',203,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4108,147,'ISCOM',204,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Corel Corporation',''),
 (4109,147,'MySQL Tools for 5,0',205,'','','2031-10-20 11:00:00','2004-03-20 14:00:00','MySQL AB, Sun Microsystems, Inc.',''),
 (4110,147,'Share',208,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Corel Corporation',''),
 (4111,147,'Microsoft Visual C++ 2010  x86 Redistributable - 10,0,40219',209,'','','2031-01-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4112,147,'Adobe Search for Help',210,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4113,147,'pgAdmin III 1,16',211,'','','2031-01-20 13:00:00','2004-03-20 14:00:00','The pgAdmin Development Team',''),
 (4114,147,'MSXML 4,0 SP2 (KB973688)',212,'','','2027-09-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4115,147,'Adobe ExtendScript Toolkit CS4',213,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4116,147,'Adobe PDF Library Files CS4',214,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4117,147,'Samsung SCX-4100 Series - TWAIN',215,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','NoName',''),
 (4118,147,'Adobe Fonts All',216,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4119,147,'Ëåãåíäà î áîëüøîé ðûáå',217,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Alawar Entertainment Inc.',''),
 (4120,147,'EPSON T50 Series Printer Uninstall',219,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','SEIKO EPSON Corporation',''),
 (4121,147,'Microsoft Help Viewer 1,0',272,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4122,147,'ßçûêîâîé ïàêåò ñðåäñòâà ïðîñìîòðà Microsoft Help 1,0 - RUS',221,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4123,147,'Îáúåêòíàÿ ìîäåëü Microsoft Team Foundation Server 2010 - RUS',222,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4124,147,'Microsoft Visual Studio 2010 Tools for Office Runtime (x64)',234,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4125,147,'ßçûêîâîé ïàêåò Microsoft Visual Studio 2010 Tools äëÿ ñðåäû âûïîëíåíèÿ Office (x64) - RUS',224,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4126,147,'PostgreSQL 9,2',225,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','NoName',''),
 (4127,147,'Total Commander 64-bit (Remove or Repair)',226,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Ghisler Software GmbH',''),
 (4128,147,'Ñèñòåìíûå òèïû Microsoft SQL Server System CLR Types (x64)',227,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4129,147,'Adobe Photoshop Lightroom 4,4 64-bit',228,'','','2001-05-20 13:00:00','2004-03-20 14:00:00','Adobe',''),
 (4130,147,'Microsoft Help Viewer 1,0 Language Pack - RUS',229,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4131,147,'Microsoft SQL Server Compact 3,5 SP2 x64 RUS',230,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4132,147,'Microsoft ,NET Framework 4,5',254,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4133,147,'Microsoft Visual C++ 2010  x64 Redistributable - 10,0,40219',232,'','','2031-01-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4134,147,'7-Zip 9,20 (x64 edition)',233,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Igor Pavlov',''),
 (4135,147,'Adobe WinSoft Linguistics Plugin x64',235,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4136,147,'Photoshop Camera Raw_x64',236,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4137,147,'Microsoft Visual C++ 2008 Redistributable - x64 9,0,21022',237,'','','2020-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4138,147,'Microsoft Sync Services for ADO,NET v2,0 SP1 (x64) ru',238,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4139,147,'Adobe Fonts All x64',239,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4140,147,'Microsoft System CLR Types äëÿ SQL Server 2012 (x64)',240,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4141,147,'Visual Studio 2010 Prerequisites - English',241,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4142,147,'Microsoft Visual C++ 2005 Redistributable (x64)',242,'','','2004-11-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4143,147,'Microsoft Visual C++ 2008 Redistributable - x64 9,0,30729,17',243,'','','2003-10-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4144,147,'Adobe Linguistics CS4 x64',244,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4145,147,'Adobe Anchor Service x64 CS4',245,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4146,147,'Microsoft Sync Framework Runtime v1,0 SP1 (x64) ru',246,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4147,147,'Óïðàâëÿþùèå îáúåêòû Microsoft SQL Server 2008 R2 (x64)',247,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4148,147,'Adobe Type Support x64 CS4',248,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4149,147,'Adobe CSI CS4 x64',249,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4150,147,'Microsoft Office Office 64-bit Components 2007',250,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4151,147,'Microsoft Office Shared 64-bit MUI (Russian) 2007',251,'','','2027-03-20 12:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4152,147,'Microsoft Sync Framework Services v1,0 SP1 (x64) ru',252,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4153,147,'Adobe CMaps x64 CS4',253,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4154,147,'ßçûêîâîé ïàêåò Microsoft ,NET Framework 4,5 - RUS',255,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Êîðïîðàöèÿ Ìàéêðîñîôò',''),
 (4155,147,'Microsoft Visual C++ 2010  x64 Runtime - 10,0,30319',256,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4156,147,'Adobe Drive CS4 x64',257,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4157,147,'Microsoft Web Deploy 3,0',258,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4158,147,'NVIDIA Äðàéâåð 3D Vision 310,90',259,'','','2016-02-20 13:00:00','2004-03-20 14:00:00','NVIDIA Corporation',''),
 (4159,147,'NVIDIA Ãðàôè÷åñêèé äðàéâåð 310,90',260,'','','2016-02-20 13:00:00','2004-03-20 14:00:00','NVIDIA Corporation',''),
 (4160,147,'NVIDIA Äðàéâåð êîíòðîëëåðà 3D Vision 310,90',261,'','','2016-02-20 13:00:00','2004-03-20 14:00:00','NVIDIA Corporation',''),
 (4161,147,'NVIDIA Ñèñòåìíîå ïðîãðàììíîå îáåñïå÷åíèå PhysX 9,12,1031',262,'','','2016-02-20 13:00:00','2004-03-20 14:00:00','NVIDIA Corporation',''),
 (4162,147,'Îáíîâëåíèÿ NVIDIA 1,11,3',263,'','','2016-02-20 13:00:00','2004-03-20 14:00:00','NVIDIA Corporation',''),
 (4163,147,'TortoiseHg 2,8,0 (x64)',264,'','','2027-05-20 13:00:00','2004-03-20 14:00:00','Steve Borho and others',''),
 (4164,147,'Microsoft ,NET Framework 4,5 RUS Language Pack',265,'','','2015-03-20 13:00:00','2004-03-20 14:00:00','Êîðïîðàöèÿ Ìàéêðîñîôò',''),
 (4165,147,'Share64',266,'','','2005-12-20 12:00:00','2004-03-20 14:00:00','Corel Corporation',''),
 (4166,147,'Adobe Photoshop CS4 (64 Bit)',267,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4167,147,'Microsoft Team Foundation Server 2010 Object Model - RUS',268,'','','2012-07-20 11:00:00','2004-03-20 14:00:00','Microsoft Corporation',''),
 (4168,147,'TortoiseGit 1,7,10,0 (64 bit)',269,'','','2027-06-20 12:00:00','2004-03-20 14:00:00','TortoiseGit',''),
 (4169,147,'Adobe PDF Library Files x64 CS4',270,'','','2022-12-20 11:00:00','2004-03-20 14:00:00','Adobe Systems Incorporated',''),
 (4170,147,'Oracle VM VirtualBox 4,2,10',271,'','','2020-03-20 13:00:00','2004-03-20 14:00:00','Oracle Corporation',''),
 (4171,147,'Microsoft Windows 7 Ìàêñèìàëüíàÿ ',273,'','MHFPT-8C8M2-V9488-FGM44-2C9T3','2004-03-20 14:00:00','2004-03-20 14:00:00','Microsoft Corporation','');
/*!40000 ALTER TABLE `SOFT_INSTALL` ENABLE KEYS */;


--
-- Definition of table `SPR_ASISTEM`
--

DROP TABLE IF EXISTS `SPR_ASISTEM`;
CREATE TABLE `SPR_ASISTEM` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_ASISTEM`
--

/*!40000 ALTER TABLE `SPR_ASISTEM` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_ASISTEM` ENABLE KEYS */;


--
-- Definition of table `SPR_BP`
--

DROP TABLE IF EXISTS `SPR_BP`;
CREATE TABLE `SPR_BP` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_BP`
--

/*!40000 ALTER TABLE `SPR_BP` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_BP` ENABLE KEYS */;


--
-- Definition of table `SPR_CASE`
--

DROP TABLE IF EXISTS `SPR_CASE`;
CREATE TABLE `SPR_CASE` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_CASE`
--

/*!40000 ALTER TABLE `SPR_CASE` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_CASE` ENABLE KEYS */;


--
-- Definition of table `SPR_CPU`
--

DROP TABLE IF EXISTS `SPR_CPU`;
CREATE TABLE `SPR_CPU` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_CPU`
--

/*!40000 ALTER TABLE `SPR_CPU` DISABLE KEYS */;
INSERT INTO `SPR_CPU` (`ID`,`Name`,`Proizv`,`Prim`,`A`,`B`,`C`) VALUES 
 (76,'AMD Phenom(tm) 8650 Triple-Core Processor',990,NULL,'2300','AM2',NULL);
/*!40000 ALTER TABLE `SPR_CPU` ENABLE KEYS */;


--
-- Definition of table `SPR_CREADER`
--

DROP TABLE IF EXISTS `SPR_CREADER`;
CREATE TABLE `SPR_CREADER` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_CREADER`
--

/*!40000 ALTER TABLE `SPR_CREADER` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_CREADER` ENABLE KEYS */;


--
-- Definition of table `SPR_Complect`
--

DROP TABLE IF EXISTS `SPR_Complect`;
CREATE TABLE `SPR_Complect` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_Complect`
--

/*!40000 ALTER TABLE `SPR_Complect` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_Complect` ENABLE KEYS */;


--
-- Definition of table `SPR_DEV_NET`
--

DROP TABLE IF EXISTS `SPR_DEV_NET`;
CREATE TABLE `SPR_DEV_NET` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_DEV_NET`
--

/*!40000 ALTER TABLE `SPR_DEV_NET` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_DEV_NET` ENABLE KEYS */;


--
-- Definition of table `SPR_FDD`
--

DROP TABLE IF EXISTS `SPR_FDD`;
CREATE TABLE `SPR_FDD` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_FDD`
--

/*!40000 ALTER TABLE `SPR_FDD` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_FDD` ENABLE KEYS */;


--
-- Definition of table `SPR_FILIAL`
--

DROP TABLE IF EXISTS `SPR_FILIAL`;
CREATE TABLE `SPR_FILIAL` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `FILIAL` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  `ARHIV` int(11) NOT NULL DEFAULT '0',
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `FILIAL` (`FILIAL`)
) ENGINE=InnoDB AUTO_INCREMENT=303 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_FILIAL`
--

/*!40000 ALTER TABLE `SPR_FILIAL` DISABLE KEYS */;
INSERT INTO `SPR_FILIAL` (`ID`,`FILIAL`,`Proizv`,`Prim`,`A`,`B`,`C`,`ARHIV`) VALUES 
 (302,'test',0,NULL,NULL,NULL,NULL,0);
/*!40000 ALTER TABLE `SPR_FILIAL` ENABLE KEYS */;


--
-- Definition of table `SPR_FS`
--

DROP TABLE IF EXISTS `SPR_FS`;
CREATE TABLE `SPR_FS` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_FS`
--

/*!40000 ALTER TABLE `SPR_FS` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_FS` ENABLE KEYS */;


--
-- Definition of table `SPR_HDD`
--

DROP TABLE IF EXISTS `SPR_HDD`;
CREATE TABLE `SPR_HDD` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id` (`id`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=90 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_HDD`
--

/*!40000 ALTER TABLE `SPR_HDD` DISABLE KEYS */;
INSERT INTO `SPR_HDD` (`id`,`Name`,`Proizv`,`Prim`,`A`,`B`,`C`) VALUES 
 (88,'ST3500410AS ATA Device',993,NULL,'466 ÃÁ',NULL,NULL),
 (89,'ST3750528AS ATA Device',993,NULL,'699 ÃÁ',NULL,NULL);
/*!40000 ALTER TABLE `SPR_HDD` ENABLE KEYS */;


--
-- Definition of table `SPR_IBP`
--

DROP TABLE IF EXISTS `SPR_IBP`;
CREATE TABLE `SPR_IBP` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_IBP`
--

/*!40000 ALTER TABLE `SPR_IBP` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_IBP` ENABLE KEYS */;


--
-- Definition of table `SPR_KAB`
--

DROP TABLE IF EXISTS `SPR_KAB`;
CREATE TABLE `SPR_KAB` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `N_F` varchar(255) DEFAULT NULL,
  `N_M` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  `ARHIV` int(11) NOT NULL DEFAULT '0',
  UNIQUE KEY `ID` (`ID`),
  KEY `Name` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=310 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_KAB`
--

/*!40000 ALTER TABLE `SPR_KAB` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_KAB` ENABLE KEYS */;


--
-- Definition of table `SPR_KEYBOARD`
--

DROP TABLE IF EXISTS `SPR_KEYBOARD`;
CREATE TABLE `SPR_KEYBOARD` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_KEYBOARD`
--

/*!40000 ALTER TABLE `SPR_KEYBOARD` DISABLE KEYS */;
INSERT INTO `SPR_KEYBOARD` (`ID`,`Name`,`Proizv`,`Prim`,`A`,`B`,`C`) VALUES 
 (20,'Enhanced (101- or 102-key)',992,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `SPR_KEYBOARD` ENABLE KEYS */;


--
-- Definition of table `SPR_KOPIR`
--

DROP TABLE IF EXISTS `SPR_KOPIR`;
CREATE TABLE `SPR_KOPIR` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_KOPIR`
--

/*!40000 ALTER TABLE `SPR_KOPIR` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_KOPIR` ENABLE KEYS */;


--
-- Definition of table `SPR_LIC`
--

DROP TABLE IF EXISTS `SPR_LIC`;
CREATE TABLE `SPR_LIC` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_LIC`
--

/*!40000 ALTER TABLE `SPR_LIC` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_LIC` ENABLE KEYS */;


--
-- Definition of table `SPR_MB`
--

DROP TABLE IF EXISTS `SPR_MB`;
CREATE TABLE `SPR_MB` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=153 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_MB`
--

/*!40000 ALTER TABLE `SPR_MB` DISABLE KEYS */;
INSERT INTO `SPR_MB` (`ID`,`Name`,`Proizv`,`Prim`,`A`,`B`,`C`) VALUES 
 (152,'M3A78',991,NULL,'',NULL,NULL);
/*!40000 ALTER TABLE `SPR_MB` ENABLE KEYS */;


--
-- Definition of table `SPR_MESTO`
--

DROP TABLE IF EXISTS `SPR_MESTO`;
CREATE TABLE `SPR_MESTO` (
  `MESTOID` int(11) NOT NULL AUTO_INCREMENT,
  `MESTO` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  `ARHIV` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`MESTOID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_MESTO`
--

/*!40000 ALTER TABLE `SPR_MESTO` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_MESTO` ENABLE KEYS */;


--
-- Definition of table `SPR_MFU`
--

DROP TABLE IF EXISTS `SPR_MFU`;
CREATE TABLE `SPR_MFU` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_MFU`
--

/*!40000 ALTER TABLE `SPR_MFU` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_MFU` ENABLE KEYS */;


--
-- Definition of table `SPR_MODEM`
--

DROP TABLE IF EXISTS `SPR_MODEM`;
CREATE TABLE `SPR_MODEM` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_MODEM`
--

/*!40000 ALTER TABLE `SPR_MODEM` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_MODEM` ENABLE KEYS */;


--
-- Definition of table `SPR_MONITOR`
--

DROP TABLE IF EXISTS `SPR_MONITOR`;
CREATE TABLE `SPR_MONITOR` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=80 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_MONITOR`
--

/*!40000 ALTER TABLE `SPR_MONITOR` DISABLE KEYS */;
INSERT INTO `SPR_MONITOR` (`ID`,`Name`,`Proizv`,`Prim`,`A`,`B`,`C`) VALUES 
 (79,'Óíèâåðñàëüíûé ìîíèòîð PnP',994,NULL,'',NULL,NULL);
/*!40000 ALTER TABLE `SPR_MONITOR` ENABLE KEYS */;


--
-- Definition of table `SPR_MOUSE`
--

DROP TABLE IF EXISTS `SPR_MOUSE`;
CREATE TABLE `SPR_MOUSE` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_MOUSE`
--

/*!40000 ALTER TABLE `SPR_MOUSE` DISABLE KEYS */;
INSERT INTO `SPR_MOUSE` (`ID`,`Name`,`Proizv`,`Prim`,`A`,`B`,`C`) VALUES 
 (24,'USB-óñòðîéñòâî ââîäà',992,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `SPR_MOUSE` ENABLE KEYS */;


--
-- Definition of table `SPR_Master`
--

DROP TABLE IF EXISTS `SPR_Master`;
CREATE TABLE `SPR_Master` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  UNIQUE KEY `Name` (`Name`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_Master`
--

/*!40000 ALTER TABLE `SPR_Master` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_Master` ENABLE KEYS */;


--
-- Definition of table `SPR_NET`
--

DROP TABLE IF EXISTS `SPR_NET`;
CREATE TABLE `SPR_NET` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=129 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_NET`
--

/*!40000 ALTER TABLE `SPR_NET` DISABLE KEYS */;
INSERT INTO `SPR_NET` (`ID`,`Name`,`Proizv`,`Prim`,`A`,`B`,`C`) VALUES 
 (128,'Ñåòåâàÿ êàðòà Realtek RTL8168C(P)/8111C(P) Family PCI-E Gigabit Ethernet NIC (NDIS 6.20)',992,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `SPR_NET` ENABLE KEYS */;


--
-- Definition of table `SPR_NET_DEV`
--

DROP TABLE IF EXISTS `SPR_NET_DEV`;
CREATE TABLE `SPR_NET_DEV` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_NET_DEV`
--

/*!40000 ALTER TABLE `SPR_NET_DEV` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_NET_DEV` ENABLE KEYS */;


--
-- Definition of table `SPR_OPTICAL`
--

DROP TABLE IF EXISTS `SPR_OPTICAL`;
CREATE TABLE `SPR_OPTICAL` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=288 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_OPTICAL`
--

/*!40000 ALTER TABLE `SPR_OPTICAL` DISABLE KEYS */;
INSERT INTO `SPR_OPTICAL` (`ID`,`Name`,`Proizv`,`Prim`,`A`,`B`,`C`) VALUES 
 (286,'XEJ XYZO9Q74 SCSI CdRom Device',992,NULL,'',NULL,NULL),
 (287,'PIONEER DVD-RW  DVR-111D ATA Device',992,NULL,'',NULL,NULL);
/*!40000 ALTER TABLE `SPR_OPTICAL` ENABLE KEYS */;


--
-- Definition of table `SPR_OS`
--

DROP TABLE IF EXISTS `SPR_OS`;
CREATE TABLE `SPR_OS` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_OS`
--

/*!40000 ALTER TABLE `SPR_OS` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_OS` ENABLE KEYS */;


--
-- Definition of table `SPR_OTD_FILIAL`
--

DROP TABLE IF EXISTS `SPR_OTD_FILIAL`;
CREATE TABLE `SPR_OTD_FILIAL` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `N_Otd` varchar(255) DEFAULT NULL,
  `Filial` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  `ARHIV` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`),
  KEY `Filial` (`Filial`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_OTD_FILIAL`
--

/*!40000 ALTER TABLE `SPR_OTD_FILIAL` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_OTD_FILIAL` ENABLE KEYS */;


--
-- Definition of table `SPR_OTH_DEV`
--

DROP TABLE IF EXISTS `SPR_OTH_DEV`;
CREATE TABLE `SPR_OTH_DEV` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_OTH_DEV`
--

/*!40000 ALTER TABLE `SPR_OTH_DEV` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_OTH_DEV` ENABLE KEYS */;


--
-- Definition of table `SPR_OTV`
--

DROP TABLE IF EXISTS `SPR_OTV`;
CREATE TABLE `SPR_OTV` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_OTV`
--

/*!40000 ALTER TABLE `SPR_OTV` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_OTV` ENABLE KEYS */;


--
-- Definition of table `SPR_PCI`
--

DROP TABLE IF EXISTS `SPR_PCI`;
CREATE TABLE `SPR_PCI` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_PCI`
--

/*!40000 ALTER TABLE `SPR_PCI` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_PCI` ENABLE KEYS */;


--
-- Definition of table `SPR_PO`
--

DROP TABLE IF EXISTS `SPR_PO`;
CREATE TABLE `SPR_PO` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_PO`
--

/*!40000 ALTER TABLE `SPR_PO` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_PO` ENABLE KEYS */;


--
-- Definition of table `SPR_PRINTER`
--

DROP TABLE IF EXISTS `SPR_PRINTER`;
CREATE TABLE `SPR_PRINTER` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_PRINTER`
--

/*!40000 ALTER TABLE `SPR_PRINTER` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_PRINTER` ENABLE KEYS */;


--
-- Definition of table `SPR_PROIZV`
--

DROP TABLE IF EXISTS `SPR_PROIZV`;
CREATE TABLE `SPR_PROIZV` (
  `iD` int(11) NOT NULL AUTO_INCREMENT,
  `PROIZV` varchar(255) DEFAULT NULL,
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  UNIQUE KEY `iD` (`iD`),
  KEY `PROIZV` (`PROIZV`)
) ENGINE=InnoDB AUTO_INCREMENT=1051 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_PROIZV`
--

/*!40000 ALTER TABLE `SPR_PROIZV` DISABLE KEYS */;
INSERT INTO `SPR_PROIZV` (`iD`,`PROIZV`,`Prim`,`A`,`B`,`C`) VALUES 
 (990,'AuthenticAMD',NULL,NULL,NULL,NULL),
 (991,'ASUSTeK Computer INC.',NULL,NULL,NULL,NULL),
 (992,'NoName',NULL,NULL,NULL,NULL),
 (993,'(Ñòàíäàðòíûå äèñêîâûå íàêîïèòåëè)',NULL,NULL,NULL,NULL),
 (994,'(Ñòàíäàðòíûå ìîíèòîðû)',NULL,NULL,NULL,NULL),
 (995,'ÎÎÎ ËÈÃÀ ÇÀÊÎÍ',NULL,NULL,NULL,NULL),
 (996,'Adobe Systems Incorporated',NULL,NULL,NULL,NULL),
 (997,'Elcomsoft Co.Ltd.',NULL,NULL,NULL,NULL),
 (998,'ashampoo GmbH & Co. KG',NULL,NULL,NULL,NULL),
 (999,'CometNetwork',NULL,NULL,NULL,NULL),
 (1000,'Canon Inc.',NULL,NULL,NULL,NULL),
 (1001,'DT Soft Ltd',NULL,NULL,NULL,NULL),
 (1002,'Microsoft Corporation',NULL,NULL,NULL,NULL),
 (1003,'Lavalys, Inc.',NULL,NULL,NULL,NULL),
 (1004,'Google Inc.',NULL,NULL,NULL,NULL),
 (1005,'Hector Maurcio Rodriguez Segura',NULL,NULL,NULL,NULL),
 (1006,'SmartSound Software Inc.',NULL,NULL,NULL,NULL),
 (1007,'Irfan Skiljan',NULL,NULL,NULL,NULL),
 (1008,'LG Electronics',NULL,NULL,NULL,NULL),
 (1009,'Mozilla',NULL,NULL,NULL,NULL),
 (1010,'Bullzip',NULL,NULL,NULL,NULL),
 (1011,'Repack by Fenixx (22.12.2012)',NULL,NULL,NULL,NULL),
 (1012,'NVIDIA Corporation',NULL,NULL,NULL,NULL),
 (1013,'EnterpriseDB',NULL,NULL,NULL,NULL),
 (1014,'Psi+ Project',NULL,NULL,NULL,NULL),
 (1015,'Simon Tatham',NULL,NULL,NULL,NULL),
 (1016,'Samsung Electronics CO.,LTD',NULL,NULL,NULL,NULL),
 (1017,'Samsung Electronics Co., Ltd.',NULL,NULL,NULL,NULL),
 (1018,'Setup',NULL,NULL,NULL,NULL),
 (1019,'SkyDNS',NULL,NULL,NULL,NULL),
 (1020,'Krzysztof Kowalczyk',NULL,NULL,NULL,NULL),
 (1021,'Ghisler Software GmbH',NULL,NULL,NULL,NULL),
 (1022,'TweakNow.com',NULL,NULL,NULL,NULL),
 (1023,'VideoLAN',NULL,NULL,NULL,NULL),
 (1024,'Windows Media Player',NULL,NULL,NULL,NULL),
 (1025,'Corel Corporation',NULL,NULL,NULL,NULL),
 (1026,'R.G. ReCoding - by Donald Dark , Inc.',NULL,NULL,NULL,NULL),
 (1027,'JetBrains Inc',NULL,NULL,NULL,NULL),
 (1028,'ÎÎÎ \"Äîêòîð Âåá\"',NULL,NULL,NULL,NULL),
 (1029,'Detong Technology Ltd.',NULL,NULL,NULL,NULL),
 (1030,'The Document Foundation',NULL,NULL,NULL,NULL),
 (1031,'Vimicro Corporation',NULL,NULL,NULL,NULL),
 (1032,'Oracle Corporation',NULL,NULL,NULL,NULL),
 (1033,'OOO SUPERPRINT',NULL,NULL,NULL,NULL),
 (1034,'Skype Technologies S.A.',NULL,NULL,NULL,NULL),
 (1035,'Rosetta Stone Ltd.',NULL,NULL,NULL,NULL),
 (1036,'PostgreSQL Global Development Group',NULL,NULL,NULL,NULL),
 (1037,'MobyArt',NULL,NULL,NULL,NULL),
 (1038,'Microsoft',NULL,NULL,NULL,NULL),
 (1039,'SAP',NULL,NULL,NULL,NULL),
 (1040,'SEIKO EPSON CORPORATION',NULL,NULL,NULL,NULL),
 (1041,'UBit Schweiz AG',NULL,NULL,NULL,NULL),
 (1042,'astrojargon.net',NULL,NULL,NULL,NULL),
 (1043,'MySQL AB, Sun Microsystems, Inc.',NULL,NULL,NULL,NULL),
 (1044,'The pgAdmin Development Team',NULL,NULL,NULL,NULL),
 (1045,'Alawar Entertainment Inc.',NULL,NULL,NULL,NULL),
 (1046,'Adobe',NULL,NULL,NULL,NULL),
 (1047,'Igor Pavlov',NULL,NULL,NULL,NULL),
 (1048,'Êîðïîðàöèÿ Ìàéêðîñîôò',NULL,NULL,NULL,NULL),
 (1049,'Steve Borho and others',NULL,NULL,NULL,NULL),
 (1050,'TortoiseGit',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `SPR_PROIZV` ENABLE KEYS */;


--
-- Definition of table `SPR_Postav`
--

DROP TABLE IF EXISTS `SPR_Postav`;
CREATE TABLE `SPR_Postav` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_Postav`
--

/*!40000 ALTER TABLE `SPR_Postav` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_Postav` ENABLE KEYS */;


--
-- Definition of table `SPR_RAM`
--

DROP TABLE IF EXISTS `SPR_RAM`;
CREATE TABLE `SPR_RAM` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Proizv` (`Proizv`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_RAM`
--

/*!40000 ALTER TABLE `SPR_RAM` DISABLE KEYS */;
INSERT INTO `SPR_RAM` (`ID`,`Name`,`Proizv`,`Prim`,`A`,`B`,`C`) VALUES 
 (48,'8 ÃÁ',992,NULL,'',NULL,NULL);
/*!40000 ALTER TABLE `SPR_RAM` ENABLE KEYS */;


--
-- Definition of table `SPR_SCANER`
--

DROP TABLE IF EXISTS `SPR_SCANER`;
CREATE TABLE `SPR_SCANER` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Proizv` (`Proizv`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_SCANER`
--

/*!40000 ALTER TABLE `SPR_SCANER` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_SCANER` ENABLE KEYS */;


--
-- Definition of table `SPR_SOUND`
--

DROP TABLE IF EXISTS `SPR_SOUND`;
CREATE TABLE `SPR_SOUND` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Proizv` (`Proizv`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=119 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_SOUND`
--

/*!40000 ALTER TABLE `SPR_SOUND` DISABLE KEYS */;
INSERT INTO `SPR_SOUND` (`ID`,`Name`,`Proizv`,`Prim`,`A`,`B`,`C`) VALUES 
 (118,'Àóäèî óñòðîéñòâà USB',992,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `SPR_SOUND` ENABLE KEYS */;


--
-- Definition of table `SPR_SVGA`
--

DROP TABLE IF EXISTS `SPR_SVGA`;
CREATE TABLE `SPR_SVGA` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Proizv` (`Proizv`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=126 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_SVGA`
--

/*!40000 ALTER TABLE `SPR_SVGA` DISABLE KEYS */;
INSERT INTO `SPR_SVGA` (`ID`,`Name`,`Proizv`,`Prim`,`A`,`B`,`C`) VALUES 
 (125,'NVIDIA GeForce 9600 GT',992,NULL,'1024 Ìá.',NULL,NULL);
/*!40000 ALTER TABLE `SPR_SVGA` ENABLE KEYS */;


--
-- Definition of table `SPR_TIP`
--

DROP TABLE IF EXISTS `SPR_TIP`;
CREATE TABLE `SPR_TIP` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Tip` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_TIP`
--

/*!40000 ALTER TABLE `SPR_TIP` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_TIP` ENABLE KEYS */;


--
-- Definition of table `SPR_TIP_PO`
--

DROP TABLE IF EXISTS `SPR_TIP_PO`;
CREATE TABLE `SPR_TIP_PO` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Prim` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_TIP_PO`
--

/*!40000 ALTER TABLE `SPR_TIP_PO` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_TIP_PO` ENABLE KEYS */;


--
-- Definition of table `SPR_USB`
--

DROP TABLE IF EXISTS `SPR_USB`;
CREATE TABLE `SPR_USB` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Proizv` (`Proizv`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_USB`
--

/*!40000 ALTER TABLE `SPR_USB` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_USB` ENABLE KEYS */;


--
-- Definition of table `SPR_USER`
--

DROP TABLE IF EXISTS `SPR_USER`;
CREATE TABLE `SPR_USER` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_USER`
--

/*!40000 ALTER TABLE `SPR_USER` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_USER` ENABLE KEYS */;


--
-- Definition of table `SPR_Uroven`
--

DROP TABLE IF EXISTS `SPR_Uroven`;
CREATE TABLE `SPR_Uroven` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Uroven` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  UNIQUE KEY `Uroven` (`Uroven`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `SPR_Uroven`
--

/*!40000 ALTER TABLE `SPR_Uroven` DISABLE KEYS */;
/*!40000 ALTER TABLE `SPR_Uroven` ENABLE KEYS */;


--
-- Definition of table `Sclad`
--

DROP TABLE IF EXISTS `Sclad`;
CREATE TABLE `Sclad` (
  `number` int(11) NOT NULL AUTO_INCREMENT,
  `Firma` varchar(255) DEFAULT NULL,
  `ComplectName` varchar(200) DEFAULT NULL,
  `NumberTreb` varchar(50) DEFAULT NULL,
  `Kolvo` int(11) DEFAULT '0',
  `Serial` varchar(50) DEFAULT NULL,
  `Prim` varchar(255) DEFAULT NULL,
  `Chet` varchar(30) DEFAULT NULL,
  `Garant` varchar(50) DEFAULT NULL,
  `NDS` decimal(19,4) DEFAULT '0.0000',
  `DaysAndTimes` varchar(20) DEFAULT NULL,
  `Platejka` varchar(50) DEFAULT NULL,
  `Cena` decimal(19,4) DEFAULT '0.0000',
  `Otdel` varchar(50) DEFAULT NULL,
  `Ostalos` int(11) DEFAULT '0',
  `Zatreboval` varchar(50) DEFAULT NULL,
  `CherezKogo` varchar(50) DEFAULT NULL,
  `Poluchil` varchar(50) DEFAULT NULL,
  `Filial` varchar(255) DEFAULT NULL,
  `oldNumber` int(11) DEFAULT '0',
  PRIMARY KEY (`number`),
  UNIQUE KEY `number` (`number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `Sclad`
--

/*!40000 ALTER TABLE `Sclad` DISABLE KEYS */;
/*!40000 ALTER TABLE `Sclad` ENABLE KEYS */;


--
-- Definition of table `Sheduler`
--

DROP TABLE IF EXISTS `Sheduler`;
CREATE TABLE `Sheduler` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DATA` datetime DEFAULT NULL,
  `OPIS` varchar(255) DEFAULT NULL,
  `foruser` varchar(255) DEFAULT NULL,
  `fromuser` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `Sheduler`
--

/*!40000 ALTER TABLE `Sheduler` DISABLE KEYS */;
/*!40000 ALTER TABLE `Sheduler` ENABLE KEYS */;


--
-- Definition of table `TBL_DEV_OID`
--

DROP TABLE IF EXISTS `TBL_DEV_OID`;
CREATE TABLE `TBL_DEV_OID` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Device` varchar(255) DEFAULT NULL,
  `Developer` varchar(255) DEFAULT NULL,
  `Model` varchar(255) DEFAULT NULL,
  `LOCATION_OID` varchar(255) DEFAULT NULL,
  `NETNAME_OID` varchar(255) DEFAULT NULL,
  `CONTACT_OID` varchar(255) DEFAULT NULL,
  `MODEL_OID` varchar(255) DEFAULT NULL,
  `SER_NUM_OID` varchar(255) DEFAULT NULL,
  `TIME_BATTERY_OID` varchar(255) DEFAULT NULL,
  `ZARIAD_BATTARY_OID` varchar(255) DEFAULT NULL,
  `SOST_BATTARY_OID` varchar(255) DEFAULT NULL,
  `ZAMENA_BATTARY_OID` varchar(255) DEFAULT NULL,
  `UPTIME_OID` varchar(255) DEFAULT NULL,
  `MAC_OID` varchar(255) DEFAULT NULL,
  `IN_TOK_OID` varchar(255) DEFAULT NULL,
  `OUT_TOK_OID` varchar(255) DEFAULT NULL,
  `OUTPUT_FREQ_OID` varchar(255) DEFAULT NULL,
  `OUTPUT_LOAD_OID` varchar(255) DEFAULT NULL,
  `OUTPUT_STATUS_OID` varchar(255) DEFAULT NULL,
  `SELFTEST_OID` varchar(255) DEFAULT NULL,
  `SELFTEST_DAY_OID` varchar(255) DEFAULT NULL,
  `TEMPERATURE_OID` varchar(255) DEFAULT NULL,
  `TEMPERATURE2_OID` varchar(255) DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `TBL_DEV_OID`
--

/*!40000 ALTER TABLE `TBL_DEV_OID` DISABLE KEYS */;
/*!40000 ALTER TABLE `TBL_DEV_OID` ENABLE KEYS */;


--
-- Definition of table `TBL_NET_MAG`
--

DROP TABLE IF EXISTS `TBL_NET_MAG`;
CREATE TABLE `TBL_NET_MAG` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_line` varchar(255) DEFAULT NULL,
  `tip_cab` varchar(255) DEFAULT NULL,
  `dlin_cab` int(11) DEFAULT '0',
  `tip_cab_line` varchar(255) DEFAULT NULL,
  `SVT` int(11) DEFAULT '0',
  `NET_PORT_SVT` varchar(255) DEFAULT NULL,
  `PHONE` varchar(255) DEFAULT NULL,
  `SVT_MEMO` text,
  `COMMUTATOR` int(11) DEFAULT '0',
  `NET_PORT_COMMUTATOR` varchar(255) DEFAULT NULL,
  `COMMUTATOR_MEMO` text,
  `PREF` varchar(255) DEFAULT NULL,
  `sID` int(11) DEFAULT '0',
  KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `TBL_NET_MAG`
--

/*!40000 ALTER TABLE `TBL_NET_MAG` DISABLE KEYS */;
/*!40000 ALTER TABLE `TBL_NET_MAG` ENABLE KEYS */;


--
-- Definition of table `TBL_PPR`
--

DROP TABLE IF EXISTS `TBL_PPR`;
CREATE TABLE `TBL_PPR` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ID_COMP` varchar(255) DEFAULT NULL,
  `TIP_CAB` varchar(255) DEFAULT NULL,
  `TIP_TO` varchar(255) DEFAULT NULL,
  `KVARTAL_TO` varchar(255) DEFAULT NULL,
  `YEAR_TO` varchar(255) DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `TBL_PPR`
--

/*!40000 ALTER TABLE `TBL_PPR` DISABLE KEYS */;
/*!40000 ALTER TABLE `TBL_PPR` ENABLE KEYS */;


--
-- Definition of table `T_Log`
--

DROP TABLE IF EXISTS `T_Log`;
CREATE TABLE `T_Log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `User_ID` varchar(255) DEFAULT NULL,
  `Activity` text,
  `Date` datetime DEFAULT NULL,
  `Time` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  KEY `User_ID` (`User_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=697 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `T_Log`
--

/*!40000 ALTER TABLE `T_Log` DISABLE KEYS */;
/*!40000 ALTER TABLE `T_Log` ENABLE KEYS */;


--
-- Definition of table `T_Que`
--

DROP TABLE IF EXISTS `T_Que`;
CREATE TABLE `T_Que` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `sqlsq` text,
  `Name` varchar(255) DEFAULT NULL,
  KEY `Id` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `T_Que`
--

/*!40000 ALTER TABLE `T_Que` DISABLE KEYS */;
/*!40000 ALTER TABLE `T_Que` ENABLE KEYS */;


--
-- Definition of table `T_User`
--

DROP TABLE IF EXISTS `T_User`;
CREATE TABLE `T_User` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `User_ID` varchar(20) DEFAULT NULL,
  `Password` varchar(20) DEFAULT NULL,
  `Name` varchar(30) DEFAULT NULL,
  `Level` varchar(20) DEFAULT NULL,
  `SETUP` tinyint(4) DEFAULT '0',
  `PCADD` tinyint(4) DEFAULT '0',
  `PCDEL` tinyint(4) DEFAULT '0',
  `CAPADD` tinyint(4) DEFAULT '0',
  `CAPDEL` tinyint(4) DEFAULT '0',
  `REPADD` tinyint(4) DEFAULT '0',
  `REPeD` tinyint(4) DEFAULT '0',
  `REPDEL` tinyint(4) DEFAULT '0',
  `POADD` tinyint(4) DEFAULT '0',
  `PODEL` tinyint(4) DEFAULT '0',
  `CARTR` tinyint(4) DEFAULT '0',
  `PO` tinyint(4) DEFAULT '0',
  `SCLAD` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `User_ID` (`User_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=299 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `T_User`
--

/*!40000 ALTER TABLE `T_User` DISABLE KEYS */;
INSERT INTO `T_User` (`Id`,`User_ID`,`Password`,`Name`,`Level`,`SETUP`,`PCADD`,`PCDEL`,`CAPADD`,`CAPDEL`,`REPADD`,`REPeD`,`REPDEL`,`POADD`,`PODEL`,`CARTR`,`PO`,`SCLAD`) VALUES 
 (298,'ADMINISTRATOR','SWY\\X','ADMINISTRATOR','Admin',0,0,0,0,0,0,0,0,0,0,0,0,0);
/*!40000 ALTER TABLE `T_User` ENABLE KEYS */;


--
-- Definition of table `TrebOvanie`
--

DROP TABLE IF EXISTS `TrebOvanie`;
CREATE TABLE `TrebOvanie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Nomer` varchar(50) NOT NULL,
  `dataSost` datetime DEFAULT NULL,
  `otdel` varchar(255) DEFAULT NULL,
  `computer` varchar(255) DEFAULT NULL,
  `cherezkogo` varchar(255) DEFAULT NULL,
  `zatreboval` varchar(255) DEFAULT NULL,
  `model` varchar(255) DEFAULT NULL,
  `tiporgtex` varchar(255) DEFAULT NULL,
  `cena` decimal(19,4) DEFAULT '0.0000',
  `kolich` int(11) DEFAULT '0',
  `Filial` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Nomer` (`Nomer`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `TrebOvanie`
--

/*!40000 ALTER TABLE `TrebOvanie` DISABLE KEYS */;
/*!40000 ALTER TABLE `TrebOvanie` ENABLE KEYS */;


--
-- Definition of table `USER_COMP`
--

DROP TABLE IF EXISTS `USER_COMP`;
CREATE TABLE `USER_COMP` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_COMP` int(11) DEFAULT '0',
  `USERNAME` varchar(50) DEFAULT NULL,
  `PASSWORD` varchar(50) DEFAULT NULL,
  `EMAIL` varchar(50) DEFAULT NULL,
  `EPASS` varchar(50) DEFAULT NULL,
  `FIO` varchar(255) DEFAULT NULL,
  `icq` varchar(50) DEFAULT NULL,
  `PDC` tinyint(4) DEFAULT '0',
  `MEMO` text,
  `jabber` text,
  PRIMARY KEY (`ID`),
  KEY `ID_COMP` (`ID_COMP`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `USER_COMP`
--

/*!40000 ALTER TABLE `USER_COMP` DISABLE KEYS */;
/*!40000 ALTER TABLE `USER_COMP` ENABLE KEYS */;


--
-- Definition of table `Update_Log`
--

DROP TABLE IF EXISTS `Update_Log`;
CREATE TABLE `Update_Log` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Comp` int(11) DEFAULT '0',
  `Komcl_old` text,
  `Kompl_new` text,
  `date` datetime DEFAULT NULL,
  `time` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `Update_Log`
--

/*!40000 ALTER TABLE `Update_Log` DISABLE KEYS */;
/*!40000 ALTER TABLE `Update_Log` ENABLE KEYS */;


--
-- Definition of table `ZAM_OTD`
--

DROP TABLE IF EXISTS `ZAM_OTD`;
CREATE TABLE `ZAM_OTD` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_ZAM` varchar(50) DEFAULT NULL,
  `DATE` varchar(50) DEFAULT NULL,
  `ZAMETKA` text,
  `ID_OTD` varchar(255) DEFAULT NULL,
  `Master` varchar(255) DEFAULT NULL,
  `uroven` varchar(50) DEFAULT NULL,
  `vip` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `ZAM_OTD`
--

/*!40000 ALTER TABLE `ZAM_OTD` DISABLE KEYS */;
/*!40000 ALTER TABLE `ZAM_OTD` ENABLE KEYS */;


--
-- Definition of table `Zametki`
--

DROP TABLE IF EXISTS `Zametki`;
CREATE TABLE `Zametki` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Date` datetime DEFAULT NULL,
  `Id_Comp` int(11) DEFAULT '0',
  `Zametki` text,
  `Master` varchar(255) DEFAULT NULL,
  `NomerZamKomp` varchar(255) DEFAULT NULL,
  `Comp_Name` varchar(255) DEFAULT NULL,
  `Mesto_Compa` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Id_Comp` (`Id_Comp`),
  KEY `Id` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `Zametki`
--

/*!40000 ALTER TABLE `Zametki` DISABLE KEYS */;
/*!40000 ALTER TABLE `Zametki` ENABLE KEYS */;


--
-- Definition of table `dvig`
--

DROP TABLE IF EXISTS `dvig`;
CREATE TABLE `dvig` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Comp` int(11) DEFAULT '0',
  `oldMesto` varchar(255) DEFAULT NULL,
  `NewMesto` varchar(255) DEFAULT NULL,
  `Prich` text,
  `data` datetime DEFAULT NULL,
  `time` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `Id_Comp` (`Id_Comp`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `dvig`
--

/*!40000 ALTER TABLE `dvig` DISABLE KEYS */;
/*!40000 ALTER TABLE `dvig` ENABLE KEYS */;


--
-- Definition of table `garant_comp`
--

DROP TABLE IF EXISTS `garant_comp`;
CREATE TABLE `garant_comp` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Comp` int(11) DEFAULT '0',
  `CPU_DP` varchar(50) DEFAULT NULL,
  `CPU_MP` varchar(50) DEFAULT NULL,
  `CPU_GP` varchar(50) DEFAULT NULL,
  `CPU_DPo` varchar(50) DEFAULT NULL,
  `CPU_MPo` varchar(50) DEFAULT NULL,
  `CPU_GPo` varchar(50) DEFAULT NULL,
  `CPU_POST` varchar(50) DEFAULT NULL,
  `MB_DP` varchar(50) DEFAULT NULL,
  `MB_MP` varchar(50) DEFAULT NULL,
  `MB_GP` varchar(50) DEFAULT NULL,
  `MB_DPo` varchar(50) DEFAULT NULL,
  `MB_MPo` varchar(50) DEFAULT NULL,
  `MB_GPo` varchar(50) DEFAULT NULL,
  `MB_POST` varchar(50) DEFAULT NULL,
  `RAM_DP` varchar(50) DEFAULT NULL,
  `RAM_MP` varchar(50) DEFAULT NULL,
  `RAM_GP` varchar(50) DEFAULT NULL,
  `RAM_DPo` varchar(50) DEFAULT NULL,
  `RAM_MPo` varchar(50) DEFAULT NULL,
  `RAM_GPo` varchar(50) DEFAULT NULL,
  `RAM_POST` varchar(50) DEFAULT NULL,
  `HDD_DP` varchar(50) DEFAULT NULL,
  `HDD_MP` varchar(50) DEFAULT NULL,
  `HDD_GP` varchar(50) DEFAULT NULL,
  `HDD_DPo` varchar(50) DEFAULT NULL,
  `HDD_MPo` varchar(50) DEFAULT NULL,
  `HDD_GPo` varchar(50) DEFAULT NULL,
  `HDD_POST` varchar(50) DEFAULT NULL,
  `SVGA_DP` varchar(50) DEFAULT NULL,
  `SVGA_MP` varchar(50) DEFAULT NULL,
  `SVGA_GP` varchar(50) DEFAULT NULL,
  `SVGA_DPo` varchar(50) DEFAULT NULL,
  `SVGA_MPo` varchar(50) DEFAULT NULL,
  `SVGA_GPo` varchar(50) DEFAULT NULL,
  `SVGA_POST` varchar(50) DEFAULT NULL,
  `SOUND_DP` varchar(50) DEFAULT NULL,
  `SOUND_MP` varchar(50) DEFAULT NULL,
  `SOUND_GP` varchar(50) DEFAULT NULL,
  `SOUND_DPo` varchar(50) DEFAULT NULL,
  `SOUND_MPo` varchar(50) DEFAULT NULL,
  `SOUND_GPo` varchar(50) DEFAULT NULL,
  `SOUND_POST` varchar(50) DEFAULT NULL,
  `CDROM_DP` varchar(50) DEFAULT NULL,
  `CDROM_MP` varchar(50) DEFAULT NULL,
  `CDROM_GP` varchar(50) DEFAULT NULL,
  `CDROM_DPo` varchar(50) DEFAULT NULL,
  `CDROM_MPo` varchar(50) DEFAULT NULL,
  `CDROM_GPo` varchar(50) DEFAULT NULL,
  `CDROM_POST` varchar(50) DEFAULT NULL,
  `NET_DP` varchar(50) DEFAULT NULL,
  `NET_MP` varchar(50) DEFAULT NULL,
  `NET_GP` varchar(50) DEFAULT NULL,
  `NET_DPo` varchar(50) DEFAULT NULL,
  `NET_MPo` varchar(50) DEFAULT NULL,
  `NET_GPo` varchar(50) DEFAULT NULL,
  `NET_POST` varchar(50) DEFAULT NULL,
  `MODEM_DP` varchar(50) DEFAULT NULL,
  `MODEM_MP` varchar(50) DEFAULT NULL,
  `MODEM_GP` varchar(50) DEFAULT NULL,
  `MODEM_DPo` varchar(50) DEFAULT NULL,
  `MODEM_MPo` varchar(50) DEFAULT NULL,
  `MODEM_GPo` varchar(50) DEFAULT NULL,
  `MODEM_POST` varchar(50) DEFAULT NULL,
  `MONITOR_DP` varchar(50) DEFAULT NULL,
  `MONITOR_MP` varchar(50) DEFAULT NULL,
  `MONITOR_GP` varchar(50) DEFAULT NULL,
  `MONITOR_DPo` varchar(50) DEFAULT NULL,
  `MONITOR_MPo` varchar(50) DEFAULT NULL,
  `MONITOR_GPo` varchar(50) DEFAULT NULL,
  `MONITOR_POST` varchar(50) DEFAULT NULL,
  `SCANER_DP` varchar(50) DEFAULT NULL,
  `SCANER_MP` varchar(50) DEFAULT NULL,
  `SCANER_GP` varchar(50) DEFAULT NULL,
  `SCANER_DPo` varchar(50) DEFAULT NULL,
  `SCANER_MPo` varchar(50) DEFAULT NULL,
  `SCANER_GPo` varchar(50) DEFAULT NULL,
  `SCANER_POST` varchar(50) DEFAULT NULL,
  `AS_DP` varchar(50) DEFAULT NULL,
  `AS_MP` varchar(50) DEFAULT NULL,
  `AS_GP` varchar(50) DEFAULT NULL,
  `AS_DPo` varchar(50) DEFAULT NULL,
  `AS_MPo` varchar(50) DEFAULT NULL,
  `AS_GPo` varchar(50) DEFAULT NULL,
  `AS_POST` varchar(50) DEFAULT NULL,
  `KEYBOARD_DP` varchar(50) DEFAULT NULL,
  `KEYBOARD_MP` varchar(50) DEFAULT NULL,
  `KEYBOARD_GP` varchar(50) DEFAULT NULL,
  `KEYBOARD_DPo` varchar(50) DEFAULT NULL,
  `KEYBOARD_MPo` varchar(50) DEFAULT NULL,
  `KEYBOARD_GPo` varchar(50) DEFAULT NULL,
  `KEYBOARD_POST` varchar(50) DEFAULT NULL,
  `MOUSE_DP` varchar(50) DEFAULT NULL,
  `MOUSE_MP` varchar(50) DEFAULT NULL,
  `MOUSE_GP` varchar(50) DEFAULT NULL,
  `MOUSE_DPo` varchar(50) DEFAULT NULL,
  `MOUSE_MPo` varchar(50) DEFAULT NULL,
  `MOUSE_GPo` varchar(50) DEFAULT NULL,
  `MOUSE_POST` varchar(50) DEFAULT NULL,
  `IBP_DP` varchar(50) DEFAULT NULL,
  `IBP_MP` varchar(50) DEFAULT NULL,
  `IBP_GP` varchar(50) DEFAULT NULL,
  `IBP_DPo` varchar(50) DEFAULT NULL,
  `IBP_MPo` varchar(50) DEFAULT NULL,
  `IBP_GPo` varchar(50) DEFAULT NULL,
  `IBP_POST` varchar(50) DEFAULT NULL,
  `FS_DP` varchar(50) DEFAULT NULL,
  `FS_MP` varchar(50) DEFAULT NULL,
  `FS_GP` varchar(50) DEFAULT NULL,
  `FS_DPo` varchar(50) DEFAULT NULL,
  `FS_MPo` varchar(50) DEFAULT NULL,
  `FS_GPo` varchar(50) DEFAULT NULL,
  `FS_POST` varchar(50) DEFAULT NULL,
  `USB_DP` varchar(50) DEFAULT NULL,
  `USB_MP` varchar(50) DEFAULT NULL,
  `USB_GP` varchar(50) DEFAULT NULL,
  `USB_DPo` varchar(50) DEFAULT NULL,
  `USB_MPo` varchar(50) DEFAULT NULL,
  `USB_GPo` varchar(50) DEFAULT NULL,
  `USB_POST` varchar(50) DEFAULT NULL,
  `PCI_DP` varchar(50) DEFAULT NULL,
  `PCI_MP` varchar(50) DEFAULT NULL,
  `PCI_GP` varchar(50) DEFAULT NULL,
  `PCI_DPo` varchar(50) DEFAULT NULL,
  `PCI_MPo` varchar(50) DEFAULT NULL,
  `PCI_GPo` varchar(50) DEFAULT NULL,
  `PCI_POST` varchar(50) DEFAULT NULL,
  `FDD_DP` varchar(50) DEFAULT NULL,
  `FDD_MP` varchar(50) DEFAULT NULL,
  `FDD_GP` varchar(50) DEFAULT NULL,
  `FDD_DPo` varchar(50) DEFAULT NULL,
  `FDD_MPo` varchar(50) DEFAULT NULL,
  `FDD_GPo` varchar(50) DEFAULT NULL,
  `FDD_POST` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Id` (`Id`),
  KEY `Id_Comp` (`Id_Comp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `garant_comp`
--

/*!40000 ALTER TABLE `garant_comp` DISABLE KEYS */;
/*!40000 ALTER TABLE `garant_comp` ENABLE KEYS */;


--
-- Definition of table `kompy`
--

DROP TABLE IF EXISTS `kompy`;
CREATE TABLE `kompy` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CPU1` text,
  `CPUmhz1` text,
  `CPUSocket1` text,
  `CPUProizv1` text,
  `CPU2` text,
  `CPUmhz2` text,
  `CPUSocket2` text,
  `CPUProizv2` text,
  `CPU3` text,
  `CPUmhz3` text,
  `CPUSocket3` text,
  `CPUProizv3` text,
  `CPU4` text,
  `CPUmhz4` text,
  `CPUSocket4` text,
  `CPUProizv4` text,
  `MB_NAME` text,
  `Mb_Chip` text,
  `Mb_Id` text,
  `Mb_Proizvod` text,
  `RAM_1` text,
  `RAM_SN_1` text,
  `RAM_speed_1` text,
  `RAM_PROIZV_1` text,
  `RAM_2` text,
  `RAM_speed_2` text,
  `RAM_SN_2` text,
  `RAM_PROIZV_2` text,
  `RAM_3` text,
  `RAM_speed_3` text,
  `RAM_SN_3` text,
  `RAM_PROIZV_3` text,
  `RAM_4` text,
  `RAM_SN_4` text,
  `RAM_speed_4` text,
  `RAM_PROIZV_4` text,
  `ram_5` text,
  `ram_sn_5` text,
  `ram_speed_5` text,
  `ram_proizv_5` text,
  `HDD_Name_1` text,
  `HDD_OB_1` text,
  `HDD_SN_1` text,
  `HDD_PROIZV_1` text,
  `HDD_Name_2` text,
  `HDD_OB_2` text,
  `HDD_SN_2` text,
  `HDD_PROIZV_2` text,
  `HDD_Name_3` text,
  `HDD_OB_3` text,
  `HDD_SN_3` text,
  `HDD_PROIZV_3` text,
  `HDD_Name_4` text,
  `HDD_OB_4` text,
  `HDD_SN_4` text,
  `HDD_PROIZV_4` text,
  `SVGA_NAME` text,
  `SVGA_OB_RAM` text,
  `SVGA_SN` text,
  `SVGA_PROIZV` text,
  `SVGA2_NAME` text,
  `SVGA2_OB_RAM` text,
  `SVGA2_SN` text,
  `SVGA2_PROIZV` text,
  `SOUND_NAME` text,
  `SOUND_SN` text,
  `SOUND_PROIZV` text,
  `CD_NAME` text,
  `CD_SPEED` text,
  `CD_SN` text,
  `CD_PROIZV` text,
  `CDRW_NAME` text,
  `CDRW_SPEED` text,
  `CDRW_SN` text,
  `CDRW_PROIZV` text,
  `DVD_NAME` text,
  `DVD_SPEED` text,
  `DVD_SN` text,
  `DVD_PROIZV` text,
  `NET_NAME_1` text,
  `NET_IP_1` text,
  `NET_MAC_1` varchar(50) DEFAULT NULL,
  `NET_PROIZV_1` text,
  `NET_NAME_2` text,
  `NET_IP_2` text,
  `NET_MAC_2` varchar(50) DEFAULT NULL,
  `NET_PROIZV_2` text,
  `FDD_NAME` text,
  `FDD_SN` text,
  `FDD_PROIZV` text,
  `MODEM_NAME` text,
  `MODEM_SN` text,
  `MODEM_PROIZV` text,
  `KEYBOARD_NAME` text,
  `KEYBOARD_SN` text,
  `KEYBOARD_PROIZV` text,
  `MOUSE_NAME` text,
  `MOUSE_SN` text,
  `MOUSE_PROIZV` text,
  `USB_NAME` text,
  `USB_SN` text,
  `USB_PROIZV` text,
  `PCI_NAME` text,
  `PCI_SN` text,
  `PCI_PROIZV` text,
  `MONITOR_NAME` text,
  `MONITOR_DUM` text,
  `MONITOR_SN` text,
  `MONITOR_PROIZV` text,
  `MONITOR_NAME2` text,
  `MONITOR_DUM2` text,
  `MONITOR_SN2` text,
  `MONITOR_PROIZV2` text,
  `AS_NAME` text,
  `AS_SN` text,
  `AS_PROIZV` text,
  `IBP_NAME` text,
  `IBP_SN` text,
  `IBP_PROIZV` text,
  `FILTR_NAME` text,
  `FILTR_SN` text,
  `FILTR_PROIZV` text,
  `PRINTER_NAME_1` text,
  `PRINTER_SN_1` text,
  `PORT_1` text,
  `PRINTER_PROIZV_1` text,
  `PRINTER_NAME_2` text,
  `PORT_2` text,
  `PRINTER_SN_2` text,
  `PRINTER_PROIZV_2` text,
  `PRINTER_NAME_3` text,
  `PORT_3` text,
  `PRINTER_SN_3` text,
  `PRINTER_PROIZV_3` text,
  `PORT_4` text,
  `PRINTER_NAME_4` text,
  `PRINTER_SN_4` text,
  `PRINTER_PROIZV_4` text,
  `SCANER_NAME` text,
  `SCANER_SN` text,
  `SCANER_PROIZV` text,
  `NET_NAME` text,
  `PSEVDONIM` text,
  `MESTO` text,
  `kabn` text,
  `TIP_COMPA` text,
  `FILIAL` text,
  `TELEPHONE` text,
  `INV_NO_SYSTEM` text,
  `INV_NO_PRINTER` text,
  `INV_NO_MODEM` text,
  `INV_NO_SCANER` text,
  `INV_NO_MONITOR` text,
  `INV_NO_IBP` text,
  `OS` text,
  `ANTIVIRUS` text,
  `OTvetstvennyj` text,
  `Garantia_Sist` tinyint(4) DEFAULT '0',
  `Ser_N_SIS` text,
  `TipTehn` varchar(50) DEFAULT NULL,
  `SFAktNo` varchar(10) DEFAULT NULL,
  `CenaRub` decimal(19,4) DEFAULT '0.0000',
  `StoimRub` decimal(19,4) DEFAULT '0.0000',
  `BNDS` tinyint(4) DEFAULT '0',
  `Desiat` tinyint(4) DEFAULT '0',
  `Vosemn` tinyint(4) DEFAULT '0',
  `Dvadcat` tinyint(4) DEFAULT '0',
  `dataSF` datetime DEFAULT NULL,
  `Zaiavk` varchar(50) DEFAULT NULL,
  `DataVVoda` datetime DEFAULT NULL,
  `Spisan` tinyint(4) DEFAULT '0',
  `Balans` tinyint(4) DEFAULT '0',
  `BLOCK` varchar(50) DEFAULT NULL,
  `SN_BLOCK` varchar(50) DEFAULT NULL,
  `PROIZV_BLOCK` text,
  `CREADER_NAME` text,
  `CREADER_SN` varchar(50) DEFAULT NULL,
  `CREADER_PROIZV` text,
  `CASE_NAME` text,
  `CASE_SN` varchar(50) DEFAULT NULL,
  `CASE_PROIZV` text,
  `BARKODE` text,
  `PCL` int(11) DEFAULT '0',
  `date` datetime DEFAULT NULL,
  `SYS_PR` text,
  `PATH` text,
  `SNMP_COMMUNITY` text,
  `SNMP` tinyint(4) DEFAULT '0',
  `ram_6` text,
  `ram_sn_6` text,
  `ram_speed_6` text,
  `ram_proizv_6` text,
  `ram_7` text,
  `ram_sn_7` text,
  `ram_speed_7` text,
  `ram_proizv_7` text,
  `ram_8` text,
  `ram_sn_8` text,
  `ram_speed_8` text,
  `ram_proizv_8` text,
  `hdd_name_5` text,
  `hdd_ob_5` text,
  `hdd_sn_5` text,
  `hdd_proizv_5` text,
  `hdd_name_6` text,
  `hdd_ob_6` text,
  `hdd_sn_6` text,
  `hdd_proizv_6` text,
  `hdd_name_7` text,
  `hdd_ob_7` text,
  `hdd_sn_7` text,
  `hdd_proizv_7` text,
  `hdd_name_8` text,
  `hdd_ob_8` text,
  `hdd_sn_8` text,
  `hdd_proizv_8` text,
  `data_sp` datetime DEFAULT NULL,
  `date_nb` datetime DEFAULT NULL,
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=148 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `kompy`
--

/*!40000 ALTER TABLE `kompy` DISABLE KEYS */;
INSERT INTO `kompy` (`ID`,`CPU1`,`CPUmhz1`,`CPUSocket1`,`CPUProizv1`,`CPU2`,`CPUmhz2`,`CPUSocket2`,`CPUProizv2`,`CPU3`,`CPUmhz3`,`CPUSocket3`,`CPUProizv3`,`CPU4`,`CPUmhz4`,`CPUSocket4`,`CPUProizv4`,`MB_NAME`,`Mb_Chip`,`Mb_Id`,`Mb_Proizvod`,`RAM_1`,`RAM_SN_1`,`RAM_speed_1`,`RAM_PROIZV_1`,`RAM_2`,`RAM_speed_2`,`RAM_SN_2`,`RAM_PROIZV_2`,`RAM_3`,`RAM_speed_3`,`RAM_SN_3`,`RAM_PROIZV_3`,`RAM_4`,`RAM_SN_4`,`RAM_speed_4`,`RAM_PROIZV_4`,`ram_5`,`ram_sn_5`,`ram_speed_5`,`ram_proizv_5`,`HDD_Name_1`,`HDD_OB_1`,`HDD_SN_1`,`HDD_PROIZV_1`,`HDD_Name_2`,`HDD_OB_2`,`HDD_SN_2`,`HDD_PROIZV_2`,`HDD_Name_3`,`HDD_OB_3`,`HDD_SN_3`,`HDD_PROIZV_3`,`HDD_Name_4`,`HDD_OB_4`,`HDD_SN_4`,`HDD_PROIZV_4`,`SVGA_NAME`,`SVGA_OB_RAM`,`SVGA_SN`,`SVGA_PROIZV`,`SVGA2_NAME`,`SVGA2_OB_RAM`,`SVGA2_SN`,`SVGA2_PROIZV`,`SOUND_NAME`,`SOUND_SN`,`SOUND_PROIZV`,`CD_NAME`,`CD_SPEED`,`CD_SN`,`CD_PROIZV`,`CDRW_NAME`,`CDRW_SPEED`,`CDRW_SN`,`CDRW_PROIZV`,`DVD_NAME`,`DVD_SPEED`,`DVD_SN`,`DVD_PROIZV`,`NET_NAME_1`,`NET_IP_1`,`NET_MAC_1`,`NET_PROIZV_1`,`NET_NAME_2`,`NET_IP_2`,`NET_MAC_2`,`NET_PROIZV_2`,`FDD_NAME`,`FDD_SN`,`FDD_PROIZV`,`MODEM_NAME`,`MODEM_SN`,`MODEM_PROIZV`,`KEYBOARD_NAME`,`KEYBOARD_SN`,`KEYBOARD_PROIZV`,`MOUSE_NAME`,`MOUSE_SN`,`MOUSE_PROIZV`,`USB_NAME`,`USB_SN`,`USB_PROIZV`,`PCI_NAME`,`PCI_SN`,`PCI_PROIZV`,`MONITOR_NAME`,`MONITOR_DUM`,`MONITOR_SN`,`MONITOR_PROIZV`,`MONITOR_NAME2`,`MONITOR_DUM2`,`MONITOR_SN2`,`MONITOR_PROIZV2`,`AS_NAME`,`AS_SN`,`AS_PROIZV`,`IBP_NAME`,`IBP_SN`,`IBP_PROIZV`,`FILTR_NAME`,`FILTR_SN`,`FILTR_PROIZV`,`PRINTER_NAME_1`,`PRINTER_SN_1`,`PORT_1`,`PRINTER_PROIZV_1`,`PRINTER_NAME_2`,`PORT_2`,`PRINTER_SN_2`,`PRINTER_PROIZV_2`,`PRINTER_NAME_3`,`PORT_3`,`PRINTER_SN_3`,`PRINTER_PROIZV_3`,`PORT_4`,`PRINTER_NAME_4`,`PRINTER_SN_4`,`PRINTER_PROIZV_4`,`SCANER_NAME`,`SCANER_SN`,`SCANER_PROIZV`,`NET_NAME`,`PSEVDONIM`,`MESTO`,`kabn`,`TIP_COMPA`,`FILIAL`,`TELEPHONE`,`INV_NO_SYSTEM`,`INV_NO_PRINTER`,`INV_NO_MODEM`,`INV_NO_SCANER`,`INV_NO_MONITOR`,`INV_NO_IBP`,`OS`,`ANTIVIRUS`,`OTvetstvennyj`,`Garantia_Sist`,`Ser_N_SIS`,`TipTehn`,`SFAktNo`,`CenaRub`,`StoimRub`,`BNDS`,`Desiat`,`Vosemn`,`Dvadcat`,`dataSF`,`Zaiavk`,`DataVVoda`,`Spisan`,`Balans`,`BLOCK`,`SN_BLOCK`,`PROIZV_BLOCK`,`CREADER_NAME`,`CREADER_SN`,`CREADER_PROIZV`,`CASE_NAME`,`CASE_SN`,`CASE_PROIZV`,`BARKODE`,`PCL`,`date`,`SYS_PR`,`PATH`,`SNMP_COMMUNITY`,`SNMP`,`ram_6`,`ram_sn_6`,`ram_speed_6`,`ram_proizv_6`,`ram_7`,`ram_sn_7`,`ram_speed_7`,`ram_proizv_7`,`ram_8`,`ram_sn_8`,`ram_speed_8`,`ram_proizv_8`,`hdd_name_5`,`hdd_ob_5`,`hdd_sn_5`,`hdd_proizv_5`,`hdd_name_6`,`hdd_ob_6`,`hdd_sn_6`,`hdd_proizv_6`,`hdd_name_7`,`hdd_ob_7`,`hdd_sn_7`,`hdd_proizv_7`,`hdd_name_8`,`hdd_ob_8`,`hdd_sn_8`,`hdd_proizv_8`,`data_sp`,`date_nb`) VALUES 
 (147,'AMD Phenom(tm) 8650 Triple-Core Processor','2300','AM2','AuthenticAMD','','','','','','','','','','','','','M3A78','','MF708AG00303818','ASUSTeK Computer INC.','8 ÃÁ','','','','','','','','','','','','','','','','','','','','ST3500410AS ATA Device','466 ÃÁ','6VM078VC','(Ñòàíäàðòíûå äèñêîâûå íàêîïèòåëè)','ST3750528AS ATA Device','699 ÃÁ','5VP1MES4','(Ñòàíäàðòíûå äèñêîâûå íàêîïèòåëè)','','','','','','','','','NVIDIA GeForce 9600 GT','1024 Ìá.','','','','','','','Àóäèî óñòðîéñòâà USB','','','XEJ XYZO9Q74 SCSI CdRom Device','','','','PIONEER DVD-RW  DVR-111D ATA Device','','','','','','','','Ñåòåâàÿ êàðòà Realtek RTL8168C(P)/8111C(P) Family PCI-E Gigabit Ethernet NIC (NDIS 6.20)','10.10.5.12','00:23:54:C0:AE:92','','','','','','','','','','','','Enhanced (101- or 102-key)','','','USB-óñòðîéñòâî ââîäà','','','','','','','','','Óíèâåðñàëüíûé ìîíèòîð PnP','','','(Ñòàíäàðòíûå ìîíèòîðû)','','','','','','','','','','','','','','Samsung Universal Print Driver','','','','EPSON T50 Series','','','','Samsung Universal Print Driver','','','',NULL,NULL,NULL,NULL,NULL,NULL,NULL,'ZORG','ZORG','','','Ðàáî÷àÿ ñòàíöèÿ','test','','','',NULL,NULL,'','',NULL,NULL,'',0,'','PC','0','0.0000','0.0000',0,0,0,0,'2019-10-20 13:00:00','','2019-10-20 13:00:00',0,0,'','','','','','','','','',NULL,0,NULL,'','',NULL,0,'','','','','','','','','','','','','','','','','','','','','','','','','','','','','2002-07-20 13:00:00',NULL);
/*!40000 ALTER TABLE `kompy` ENABLE KEYS */;


--
-- Definition of table `net_port`
--

DROP TABLE IF EXISTS `net_port`;
CREATE TABLE `net_port` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `id_net` int(11) DEFAULT NULL,
  `port` varchar(255) DEFAULT NULL,
  `net_n` varchar(255) DEFAULT NULL,
  `mac` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `id_net` (`id_net`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `net_port`
--

/*!40000 ALTER TABLE `net_port` DISABLE KEYS */;
/*!40000 ALTER TABLE `net_port` ENABLE KEYS */;


--
-- Definition of table `remonty_plus`
--

DROP TABLE IF EXISTS `remonty_plus`;
CREATE TABLE `remonty_plus` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_rem` int(11) NOT NULL DEFAULT '0',
  `data` datetime DEFAULT NULL,
  `master` varchar(50) NOT NULL,
  `otzyv` text,
  PRIMARY KEY (`id`),
  KEY `id_rem` (`id_rem`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `remonty_plus`
--

/*!40000 ALTER TABLE `remonty_plus` DISABLE KEYS */;
/*!40000 ALTER TABLE `remonty_plus` ENABLE KEYS */;


--
-- Definition of table `spr_cart`
--

DROP TABLE IF EXISTS `spr_cart`;
CREATE TABLE `spr_cart` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Id` (`Id`),
  KEY `Proizv` (`Proizv`),
  KEY `Proizv_2` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `spr_cart`
--

/*!40000 ALTER TABLE `spr_cart` DISABLE KEYS */;
/*!40000 ALTER TABLE `spr_cart` ENABLE KEYS */;


--
-- Definition of table `spr_fax`
--

DROP TABLE IF EXISTS `spr_fax`;
CREATE TABLE `spr_fax` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Id` (`Id`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `spr_fax`
--

/*!40000 ALTER TABLE `spr_fax` DISABLE KEYS */;
/*!40000 ALTER TABLE `spr_fax` ENABLE KEYS */;


--
-- Definition of table `spr_other`
--

DROP TABLE IF EXISTS `spr_other`;
CREATE TABLE `spr_other` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `A` varchar(255) DEFAULT NULL,
  `B` varchar(255) DEFAULT NULL,
  `C` varchar(255) DEFAULT NULL,
  `PROizV` varchar(255) DEFAULT NULL,
  `Prim` text,
  KEY `Id` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `spr_other`
--

/*!40000 ALTER TABLE `spr_other` DISABLE KEYS */;
/*!40000 ALTER TABLE `spr_other` ENABLE KEYS */;


--
-- Definition of table `spr_pdc`
--

DROP TABLE IF EXISTS `spr_pdc`;
CREATE TABLE `spr_pdc` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` text,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `spr_pdc`
--

/*!40000 ALTER TABLE `spr_pdc` DISABLE KEYS */;
/*!40000 ALTER TABLE `spr_pdc` ENABLE KEYS */;


--
-- Definition of table `spr_phone`
--

DROP TABLE IF EXISTS `spr_phone`;
CREATE TABLE `spr_phone` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Id` (`Id`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `spr_phone`
--

/*!40000 ALTER TABLE `spr_phone` DISABLE KEYS */;
/*!40000 ALTER TABLE `spr_phone` ENABLE KEYS */;


--
-- Definition of table `spr_photo`
--

DROP TABLE IF EXISTS `spr_photo`;
CREATE TABLE `spr_photo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Id` (`Id`),
  KEY `Proizv` (`Proizv`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `spr_photo`
--

/*!40000 ALTER TABLE `spr_photo` DISABLE KEYS */;
/*!40000 ALTER TABLE `spr_photo` ENABLE KEYS */;


--
-- Definition of table `spr_tip_z`
--

DROP TABLE IF EXISTS `spr_tip_z`;
CREATE TABLE `spr_tip_z` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `Prim` text,
  UNIQUE KEY `name` (`name`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `spr_tip_z`
--

/*!40000 ALTER TABLE `spr_tip_z` DISABLE KEYS */;
/*!40000 ALTER TABLE `spr_tip_z` ENABLE KEYS */;


--
-- Definition of table `spr_vip`
--

DROP TABLE IF EXISTS `spr_vip`;
CREATE TABLE `spr_vip` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  UNIQUE KEY `name` (`name`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=298 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `spr_vip`
--

/*!40000 ALTER TABLE `spr_vip` DISABLE KEYS */;
/*!40000 ALTER TABLE `spr_vip` ENABLE KEYS */;


--
-- Definition of table `spr_zip`
--

DROP TABLE IF EXISTS `spr_zip`;
CREATE TABLE `spr_zip` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `Proizv` int(11) DEFAULT '0',
  `Prim` text,
  `A` varchar(50) DEFAULT NULL,
  `B` varchar(50) DEFAULT NULL,
  `C` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Proizv` (`Proizv`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `spr_zip`
--

/*!40000 ALTER TABLE `spr_zip` DISABLE KEYS */;
/*!40000 ALTER TABLE `spr_zip` ENABLE KEYS */;


--
-- Definition of table `tbl_bios`
--

DROP TABLE IF EXISTS `tbl_bios`;
CREATE TABLE `tbl_bios` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_COMP` int(11) DEFAULT '0',
  `BU` varchar(50) DEFAULT NULL,
  `BA` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `tbl_bios`
--

/*!40000 ALTER TABLE `tbl_bios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bios` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
