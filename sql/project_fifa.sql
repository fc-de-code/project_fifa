-- phpMyAdmin SQL Dump
-- version 4.4.7
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Gegenereerd op: 18 mei 2017 om 09:10
-- Serverversie: 5.5.47-MariaDB
-- PHP-versie: 5.5.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `project_fifa`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_matches`
--

CREATE TABLE IF NOT EXISTS `tbl_matches` (
  `id` int(10) unsigned NOT NULL,
  `team_id_a` int(10) unsigned NOT NULL,
  `team_id_b` int(10) unsigned NOT NULL,
  `score_team_a` int(10) unsigned DEFAULT NULL,
  `score_team_b` int(10) unsigned DEFAULT NULL,
  `start_time` datetime NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Gegevens worden geëxporteerd voor tabel `tbl_matches`
--

INSERT INTO `tbl_matches` (`id`, `team_id_a`, `team_id_b`, `score_team_a`, `score_team_b`, `start_time`) VALUES
(1, 1, 2, 5, 4, '2017-04-13 18:00:00'),
(2, 2, 1, 10, 11, '2017-05-04 00:00:00');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_players`
--

CREATE TABLE IF NOT EXISTS `tbl_players` (
  `id` int(11) unsigned NOT NULL,
  `student_id` varchar(10) NOT NULL,
  `team_id` int(11) unsigned NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `tbl_players`
--

INSERT INTO `tbl_players` (`id`, `student_id`, `team_id`, `first_name`, `last_name`, `created_at`, `deleted_at`) VALUES
(1, 'd123456', 1, 'Lasse', 'Schöne', '2017-04-13 09:44:13', NULL),
(2, 'd5435435', 1, 'Davy ', 'Klaassen', '2017-04-13 09:44:13', NULL),
(3, 'd545454', 1, 'Hakim ', 'Ziyech', '2017-04-13 09:45:47', NULL),
(4, 'd666555', 1, 'Kasper', 'Dolberg', '2017-04-13 09:45:47', NULL),
(5, 'd74745', 2, 'Luuk', 'de Jong', '2017-04-13 09:48:23', NULL),
(6, 'd987665', 2, 'Siem', 'de Jong', '2017-04-13 09:48:23', NULL),
(7, 'd11555', 2, 'Jeroen', 'Zoet', '2017-04-13 09:48:23', NULL),
(8, 'd544566', 2, 'Hector', 'Moreno', '2017-04-13 09:48:23', NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_poules`
--

CREATE TABLE IF NOT EXISTS `tbl_poules` (
  `id` int(11) NOT NULL,
  `naam` varchar(10) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `tbl_poules`
--

INSERT INTO `tbl_poules` (`id`, `naam`, `created_at`, `deleted_at`) VALUES
(1, 'Poule A', '2017-05-05 00:07:39', NULL),
(2, 'Poule B', '2017-05-05 00:07:39', NULL),
(3, 'Poule C', '2017-05-05 00:07:39', NULL),
(4, 'Poule D', '2017-05-05 00:07:39', NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_teams`
--

CREATE TABLE IF NOT EXISTS `tbl_teams` (
  `id` int(11) unsigned NOT NULL,
  `poule_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `tbl_teams`
--

INSERT INTO `tbl_teams` (`id`, `poule_id`, `name`, `created_at`, `deleted_at`) VALUES
(1, 1, 'Ajax', '2017-04-13 09:42:45', NULL),
(2, 1, 'PSV', '2017-04-13 09:42:45', NULL);

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `tbl_matches`
--
ALTER TABLE `tbl_matches`
  ADD PRIMARY KEY (`id`),
  ADD KEY `tbl_matches_ibfk_1` (`team_id_a`),
  ADD KEY `tbl_matches_ibfk_2` (`team_id_b`);

--
-- Indexen voor tabel `tbl_players`
--
ALTER TABLE `tbl_players`
  ADD PRIMARY KEY (`id`),
  ADD KEY `team_id` (`team_id`);

--
-- Indexen voor tabel `tbl_poules`
--
ALTER TABLE `tbl_poules`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `naam` (`naam`);

--
-- Indexen voor tabel `tbl_teams`
--
ALTER TABLE `tbl_teams`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `tbl_matches`
--
ALTER TABLE `tbl_matches`
  MODIFY `id` int(10) unsigned NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT voor een tabel `tbl_players`
--
ALTER TABLE `tbl_players`
  MODIFY `id` int(11) unsigned NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT voor een tabel `tbl_poules`
--
ALTER TABLE `tbl_poules`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT voor een tabel `tbl_teams`
--
ALTER TABLE `tbl_teams`
  MODIFY `id` int(11) unsigned NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `tbl_matches`
--
ALTER TABLE `tbl_matches`
  ADD CONSTRAINT `tbl_matches_ibfk_1` FOREIGN KEY (`team_id_a`) REFERENCES `tbl_teams` (`id`),
  ADD CONSTRAINT `tbl_matches_ibfk_2` FOREIGN KEY (`team_id_b`) REFERENCES `tbl_teams` (`id`);

--
-- Beperkingen voor tabel `tbl_players`
--
ALTER TABLE `tbl_players`
  ADD CONSTRAINT `tbl_players_ibfk_1` FOREIGN KEY (`team_id`) REFERENCES `tbl_teams` (`id`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
