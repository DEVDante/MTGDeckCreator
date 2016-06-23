CREATE DATABASE  IF NOT EXISTS `mtg` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `mtg`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mtg
-- ------------------------------------------------------
-- Server version	5.7.13-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary view structure for view `cards`
--

DROP TABLE IF EXISTS `cards`;
/*!50001 DROP VIEW IF EXISTS `cards`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `cards` AS SELECT 
 1 AS `multiverseid`,
 1 AS `name`,
 1 AS `manaCost`,
 1 AS `superTypes`,
 1 AS `types`,
 1 AS `subTypes`,
 1 AS `setID`,
 1 AS `rarity`,
 1 AS `rulesText`,
 1 AS `flavorText`,
 1 AS `artist`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `creaturecards`
--

DROP TABLE IF EXISTS `creaturecards`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `creaturecards` (
  `multiverseid` int(10) unsigned NOT NULL,
  `name` varchar(45) NOT NULL,
  `manaCost` varchar(45) NOT NULL,
  `superTypes` varchar(45) DEFAULT NULL,
  `types` varchar(45) NOT NULL,
  `subTypes` varchar(45) DEFAULT NULL,
  `setID` char(3) NOT NULL,
  `rarity` enum('Common','Uncommon','Rare','Mythic Rare') DEFAULT NULL,
  `rulesText` varchar(512) DEFAULT NULL,
  `flavorText` varchar(255) DEFAULT NULL,
  `artist` varchar(45) NOT NULL,
  `setNumber` int(10) unsigned NOT NULL,
  `picture` varchar(45) DEFAULT NULL,
  `power` int(10) unsigned NOT NULL,
  `toughness` int(10) unsigned NOT NULL,
  PRIMARY KEY (`multiverseid`),
  UNIQUE KEY `multiverseid_UNIQUE` (`multiverseid`),
  KEY `setID_idx` (`setID`),
  CONSTRAINT `setID_key` FOREIGN KEY (`setID`) REFERENCES `sets` (`setID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `creaturecards`
--

LOCK TABLES `creaturecards` WRITE;
/*!40000 ALTER TABLE `creaturecards` DISABLE KEYS */;
INSERT INTO `creaturecards` VALUES (124474,'Simian Spirit Guide','{2}{R}',NULL,'Creature','Ape|Spirit','PLC','Common','Exile Simian Spirit Guide from your hand: Add {R} to your mana pool.','\"All my spells smell like burnt hair lately.\" —Jaya Ballard, task mage','Dave DeVries',122,NULL,2,2),(180607,'Sen Triplets','{2}{W}{U}{B}','Legendary','Artifact|Creature','Human|Wizard','ARB','Mythic Rare','At the beginning of your upkeep, choose target opponent. This turn, that player can\'t cast spells or activate abilities and plays with his or her hand revealed. You may play cards from that player\'s hand this turn.','They are the masters of your mind.','Greg Staples',109,'sentriplets.png',3,3),(401863,'Drowner of Hope','{5}{U}',NULL,'Creature','Eldrazi','BFZ','Rare','Devoid (This card has no color.) When Drowner of Hope enters the battlefield, put two 1/1 colorless Eldrazi Scion creature tokens onto the battlefield. They have \"Sacrifice this creature: Add {C} to your mana pool.\" Sacrifice an Eldrazi Scion: Tap target creature.',NULL,'Tomasz Jedruszek',57,NULL,5,5),(401868,'Eldrazi Skyspawner','{2}{U}',NULL,'Creature','Eldrazi|Drone','BFZ','Common','Devoid (This card has no color.) Flying When Eldrazi Skyspawner enters the battlefield, put a 1/1 colorless Eldrazi Scion creature token onto the battlefield. It has \"Sacrifice this creature: Add {C} to your mana pool.\"',NULL,'Chase Stone',58,NULL,2,1),(401871,'Endless One','{X}',NULL,'Creature','Eldrazi','BFZ','Rare','Endless One enters the battlefield with X +1/+1 counters on it.','It embodies all possible meanings of the word \"infinite.\"','Jason Felix',8,NULL,0,0),(407512,'Eldrazi Mimic','{2}',NULL,'Creature','Eldrazi','OGW','Rare','Whenever another colorless creature enters the battlefield under your control, you may change Eldrazi Mimic\'s base power and toughness to that creature\'s power and toughness until end of turn.','It is consistently inconsistent.','Craig J Spearing',2,NULL,2,1),(407517,'Reality Smasher','{4}{C}',NULL,'Creature','Eldrazi','OGW','Rare','Trample, haste Whenever Reality Smasher becomes the target of a spell an opponent controls, counter that spell unless its controller discards a card.',NULL,'Jason Rainville',7,NULL,5,5),(407519,'Thought-Knot Seer','{3}{C}',NULL,'Creature','Eldrazi','OGW','Rare','When Thought-Knot Seer enters the battlefield, target opponent reveals his or her hand. You choose a nonland card from it and exile that card. When Thought-Knot Seer leaves the battlefield, target opponent draws a card.',NULL,'Svetlin Velinov',9,NULL,4,4),(407523,'Eldrazi Displacer','{2}{W}',NULL,'Creature','Eldrazi','OGW','Rare','Devoid (This card has no color.) {2}{C}: Exile another target creature, then return it to the battlefield tapped under its owner\'s control. ({C} represents colorless mana.)',NULL,'Daarken',13,NULL,3,3);
/*!40000 ALTER TABLE `creaturecards` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `planeswalkercards`
--

DROP TABLE IF EXISTS `planeswalkercards`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `planeswalkercards` (
  `multiverseid` int(10) unsigned NOT NULL,
  `name` varchar(45) NOT NULL,
  `manaCost` varchar(45) NOT NULL,
  `superTypes` varchar(45) DEFAULT NULL,
  `types` varchar(45) NOT NULL,
  `subTypes` varchar(45) DEFAULT NULL,
  `setID` char(3) NOT NULL,
  `rarity` enum('Common','Uncommon','Rare','Mythic Rare') DEFAULT NULL,
  `rulesText` varchar(512) DEFAULT NULL,
  `flavorText` varchar(255) DEFAULT NULL,
  `artist` varchar(45) NOT NULL,
  `setNumber` int(10) unsigned NOT NULL,
  `picture` varchar(45) DEFAULT NULL,
  `loyalty` int(10) unsigned NOT NULL,
  PRIMARY KEY (`multiverseid`),
  UNIQUE KEY `multiverseid_UNIQUE` (`multiverseid`),
  KEY `setID_idx` (`setID`),
  CONSTRAINT `key` FOREIGN KEY (`setID`) REFERENCES `sets` (`setID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `planeswalkercards`
--

LOCK TABLES `planeswalkercards` WRITE;
/*!40000 ALTER TABLE `planeswalkercards` DISABLE KEYS */;
/*!40000 ALTER TABLE `planeswalkercards` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sets`
--

DROP TABLE IF EXISTS `sets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sets` (
  `setID` char(3) NOT NULL,
  `name` varchar(45) NOT NULL,
  `releaseDate` date NOT NULL,
  `devCode` varchar(45) NOT NULL,
  PRIMARY KEY (`setID`),
  UNIQUE KEY `setID_UNIQUE` (`setID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sets`
--

LOCK TABLES `sets` WRITE;
/*!40000 ALTER TABLE `sets` DISABLE KEYS */;
INSERT INTO `sets` VALUES ('ARB','Alara Reborn','2009-04-30','Scissors'),('BFZ','Battle for Zendikar','2015-10-02','Blood'),('MM2','Modern Masters 2015 Edition','2015-05-22','n/a'),('MMA','Modern Masters','2013-06-07','Picasso'),('NPH','New Phyrexia','2011-05-13','Action'),('OGW','Oath of the Gatewatch','2016-01-22','Sweat'),('PLC','Planar Chaos','2007-02-02','Crackle'),('ROE','Rise of Eldrazi','2010-04-23','Prosper'),('WWK','Worldwake','2010-02-05','Long');
/*!40000 ALTER TABLE `sets` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `spellcards`
--

DROP TABLE IF EXISTS `spellcards`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `spellcards` (
  `multiverseid` int(10) unsigned NOT NULL,
  `name` varchar(45) NOT NULL,
  `manaCost` varchar(45) NOT NULL,
  `superTypes` varchar(45) DEFAULT NULL,
  `types` varchar(45) NOT NULL,
  `subTypes` varchar(45) DEFAULT NULL,
  `setID` char(3) NOT NULL,
  `rarity` enum('Common','Uncommon','Rare','Mythic Rare') DEFAULT NULL,
  `rulesText` varchar(512) DEFAULT NULL,
  `flavorText` varchar(255) DEFAULT NULL,
  `artist` varchar(45) NOT NULL,
  `setNumber` int(10) unsigned NOT NULL,
  `picture` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`multiverseid`),
  UNIQUE KEY `multiverseid_UNIQUE` (`multiverseid`),
  KEY `setID_idx` (`setID`),
  CONSTRAINT `setID` FOREIGN KEY (`setID`) REFERENCES `sets` (`setID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spellcards`
--

LOCK TABLES `spellcards` WRITE;
/*!40000 ALTER TABLE `spellcards` DISABLE KEYS */;
INSERT INTO `spellcards` VALUES (197881,'Eye of Ugin','','Legendary','Land',NULL,'WWK','Mythic Rare','Colorless Eldrazi spells you cast cost {2} less to cast. {7}, Tap: Search your library for a colorless creature card, reveal it, and put it into your hand. Then shuffle your library.','An eye closes. A race awakens.','James Paick',136,NULL),(198312,'Eldrazi Temple','',NULL,'Land',NULL,'ROE','Rare','Tap: Add {C} to your mana pool. Tap: Add {C}{C} to your mana pool. Spend this mana only to cast {C} Eldrazi spells or activate abilities of {C} Eldrazi.','Each temple is a door to a horrible future.','James Paick',227,NULL),(230082,'Dismember','{1}{B}{B}',NULL,'Instant',NULL,'NPH','Uncommon','Target creature gets -5/-5 until end of turn.','\"You serve Phyrexia. Your pieces would better serve Phyrexia elsewhere.\" —Azax-Azog, the Demon Thane','Terese Nielsen',57,NULL),(370411,'Chalice of the Void','{X}{X}',NULL,'Artifact',NULL,'MMA','Rare','Chalice of the Void enters the battlefield with X charge counters on it. Whenever a player casts a spell with converted mana cost equal to the number of charge counters on Chalice of the Void, counter that spell.',NULL,'Mark Zug',203,NULL),(397830,'Dismember','{1}{B}{B}',NULL,'Instant',NULL,'MM2','Uncommon','Target creature gets -5/-5 until end of turn.','\"You serve Phyrexia. Your pieces would better serve Phyrexia elsewhere.\" —Azax-Azog, the Demon Thane','Terese Nielsen',79,NULL);
/*!40000 ALTER TABLE `spellcards` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `DCINumber` int(11) NOT NULL,
  `name` varchar(45) NOT NULL,
  `surname` varchar(45) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`DCINumber`),
  UNIQUE KEY `DCINumber_UNIQUE` (`DCINumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `cards`
--

/*!50001 DROP VIEW IF EXISTS `cards`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `cards` AS (select `creaturecards`.`multiverseid` AS `multiverseid`,`creaturecards`.`name` AS `name`,`creaturecards`.`manaCost` AS `manaCost`,`creaturecards`.`superTypes` AS `superTypes`,`creaturecards`.`types` AS `types`,`creaturecards`.`subTypes` AS `subTypes`,`creaturecards`.`setID` AS `setID`,`creaturecards`.`rarity` AS `rarity`,`creaturecards`.`rulesText` AS `rulesText`,`creaturecards`.`flavorText` AS `flavorText`,`creaturecards`.`artist` AS `artist` from `creaturecards`) union (select `planeswalkercards`.`multiverseid` AS `multiverseid`,`planeswalkercards`.`name` AS `name`,`planeswalkercards`.`manaCost` AS `manaCost`,`planeswalkercards`.`superTypes` AS `superTypes`,`planeswalkercards`.`types` AS `types`,`planeswalkercards`.`subTypes` AS `subTypes`,`planeswalkercards`.`setID` AS `setID`,`planeswalkercards`.`rarity` AS `rarity`,`planeswalkercards`.`rulesText` AS `rulesText`,`planeswalkercards`.`flavorText` AS `flavorText`,`planeswalkercards`.`artist` AS `artist` from `planeswalkercards`) union (select `spellcards`.`multiverseid` AS `multiverseid`,`spellcards`.`name` AS `name`,`spellcards`.`manaCost` AS `manaCost`,`spellcards`.`superTypes` AS `superTypes`,`spellcards`.`types` AS `types`,`spellcards`.`subTypes` AS `subTypes`,`spellcards`.`setID` AS `setID`,`spellcards`.`rarity` AS `rarity`,`spellcards`.`rulesText` AS `rulesText`,`spellcards`.`flavorText` AS `flavorText`,`spellcards`.`artist` AS `artist` from `spellcards`) order by `multiverseid` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-06-23 18:18:06
