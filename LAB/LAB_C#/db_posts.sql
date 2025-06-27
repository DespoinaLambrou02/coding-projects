-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Εξυπηρετητής: 127.0.0.1
-- Χρόνος δημιουργίας: 27 Μάη 2025 στις 03:58:15
-- Έκδοση διακομιστή: 10.4.32-MariaDB
-- Έκδοση PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Βάση δεδομένων: `db_posts`
--

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `posts`
--

CREATE TABLE `posts` (
  `ID_POST` int(11) NOT NULL,
  `ID_SOCIAL_NETWORK` int(11) NOT NULL,
  `DATE` date DEFAULT NULL,
  `TITLE` varchar(255) DEFAULT NULL,
  `REACH` int(11) DEFAULT NULL,
  `REACTIONS` int(11) DEFAULT NULL,
  `SHARES` int(11) DEFAULT NULL,
  `COMMENTS` int(11) DEFAULT NULL,
  `CLICKS` int(11) DEFAULT NULL,
  `SCHEDULED` date DEFAULT NULL,
  `PUBLISHED` date DEFAULT NULL,
  `LAST_UPDATED` date DEFAULT NULL,
  `LIKES` int(11) DEFAULT NULL,
  `SAVES` int(11) DEFAULT NULL,
  `DELIVERED` int(11) DEFAULT NULL,
  `OPENED` int(11) DEFAULT NULL,
  `UNSUBSCRIBES` int(11) DEFAULT NULL,
  `Views` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Άδειασμα δεδομένων του πίνακα `posts`
--

INSERT INTO `posts` (`ID_POST`, `ID_SOCIAL_NETWORK`, `DATE`, `TITLE`, `REACH`, `REACTIONS`, `SHARES`, `COMMENTS`, `CLICKS`, `SCHEDULED`, `PUBLISHED`, `LAST_UPDATED`, `LIKES`, `SAVES`, `DELIVERED`, `OPENED`, `UNSUBSCRIBES`, `Views`) VALUES
(1, 1, '2025-06-15', 'ΠΡΩΤΟ ΠΟΣΤ', 3, 54, 109, 4, 1006, '2025-07-09', '2025-07-20', '2025-05-02', 51, 1, 36, 2056, 0, 0),
(2, 6, '2025-05-26', 'New blog', NULL, NULL, NULL, NULL, NULL, '2025-05-15', '2025-05-17', '2025-05-05', NULL, NULL, NULL, NULL, NULL, 15365),
(3, 3, '2025-05-26', 'TA KATAFERA', NULL, NULL, NULL, 14411, NULL, '2025-05-16', '2025-05-16', '2025-05-03', 22552, NULL, NULL, NULL, NULL, 25552),
(4, 6, '2025-05-26', 'ΔΟΚΙΜΗ ΓΙΣ ΒΛΟΓΚ', NULL, NULL, NULL, NULL, NULL, '2025-05-18', '2025-05-10', '2025-05-04', NULL, NULL, NULL, NULL, NULL, 4),
(5, 6, '2025-05-26', 'ΤΙ ΠΑΕΙ ΛΑΘΟΣ', NULL, NULL, NULL, NULL, NULL, '2025-05-23', '2025-05-03', '2025-05-06', NULL, NULL, NULL, NULL, NULL, 5555),
(6, 6, '2025-05-26', 'NOMIZV TO EFTIAJA', NULL, NULL, NULL, NULL, NULL, '2025-05-23', '2025-05-02', '2025-05-26', NULL, NULL, NULL, NULL, NULL, 555),
(7, 3, '2025-05-27', 'MIKRH ALLAGH', NULL, NULL, NULL, 4411, NULL, '2025-05-10', '0001-01-01', '2025-05-27', 555, NULL, NULL, NULL, NULL, 444),
(8, 3, '2025-05-27', 'GIA NA DV TI UA BGEI', NULL, NULL, NULL, 251, NULL, '2025-05-18', NULL, '2025-05-27', 141, NULL, NULL, NULL, NULL, 254),
(9, 3, '2025-05-27', 'KAI ALLH DOKIMH ', NULL, NULL, NULL, 4556, NULL, '2025-05-23', '2025-05-27', '2025-05-27', 565, NULL, NULL, NULL, NULL, 555),
(10, 5, '2025-05-27', 'ΕΛΑ ΛΙΓΟ ΑΚΟΜΑ', NULL, NULL, NULL, NULL, 25456, '2025-05-27', '2025-05-24', '2025-05-27', NULL, NULL, 5566, 8, 596, NULL),
(11, 6, '2025-05-27', 'TEST TEST', NULL, NULL, NULL, NULL, NULL, '2025-05-25', NULL, '2025-05-27', NULL, NULL, NULL, NULL, NULL, 4265),
(12, 5, '2025-05-27', 'TELEYTAIA', NULL, NULL, NULL, NULL, 1, '2025-05-22', '2025-05-27', '2025-05-27', NULL, NULL, 455, 11, 44, NULL);

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `social_networks`
--

CREATE TABLE `social_networks` (
  `ID_SOCIAL_NTEWOK` int(11) NOT NULL,
  `NAME_SOCIAL_NETWORK` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Άδειασμα δεδομένων του πίνακα `social_networks`
--

INSERT INTO `social_networks` (`ID_SOCIAL_NTEWOK`, `NAME_SOCIAL_NETWORK`) VALUES
(1, 'FACEBOOK'),
(2, 'INSTAGRAM'),
(3, 'TIKTOK'),
(4, 'LINKEDLN'),
(5, 'NEWSLETTER'),
(6, 'BLOG');

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `tags`
--

CREATE TABLE `tags` (
  `ID_TAG` int(11) NOT NULL,
  `TITLE_TAG` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Άδειασμα δεδομένων του πίνακα `tags`
--

INSERT INTO `tags` (`ID_TAG`, `TITLE_TAG`) VALUES
(1, 'RiRi 2025'),
(2, 'Delulu'),
(3, 'Drake 2025'),
(4, '#PopMusic'),
(5, 'Luxury'),
(6, 'Summer vibes'),
(7, 'LOKO'),
(8, 'Afrobeat'),
(9, 'heyyyyy'),
(10, 'LastTag');

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `tags_posts`
--

CREATE TABLE `tags_posts` (
  `ID_POST` int(11) NOT NULL,
  `ID_TAG` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Ευρετήρια για άχρηστους πίνακες
--

--
-- Ευρετήρια για πίνακα `posts`
--
ALTER TABLE `posts`
  ADD PRIMARY KEY (`ID_POST`),
  ADD KEY `ID_SOCIAL_NETWORK` (`ID_SOCIAL_NETWORK`);

--
-- Ευρετήρια για πίνακα `social_networks`
--
ALTER TABLE `social_networks`
  ADD PRIMARY KEY (`ID_SOCIAL_NTEWOK`);

--
-- Ευρετήρια για πίνακα `tags`
--
ALTER TABLE `tags`
  ADD PRIMARY KEY (`ID_TAG`);

--
-- Ευρετήρια για πίνακα `tags_posts`
--
ALTER TABLE `tags_posts`
  ADD KEY `ID_POST` (`ID_POST`),
  ADD KEY `ID_TAG` (`ID_TAG`);

--
-- AUTO_INCREMENT για άχρηστους πίνακες
--

--
-- AUTO_INCREMENT για πίνακα `posts`
--
ALTER TABLE `posts`
  MODIFY `ID_POST` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT για πίνακα `social_networks`
--
ALTER TABLE `social_networks`
  MODIFY `ID_SOCIAL_NTEWOK` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT για πίνακα `tags`
--
ALTER TABLE `tags`
  MODIFY `ID_TAG` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Περιορισμοί για άχρηστους πίνακες
--

--
-- Περιορισμοί για πίνακα `posts`
--
ALTER TABLE `posts`
  ADD CONSTRAINT `posts_ibfk_1` FOREIGN KEY (`ID_SOCIAL_NETWORK`) REFERENCES `social_networks` (`ID_SOCIAL_NTEWOK`);

--
-- Περιορισμοί για πίνακα `tags_posts`
--
ALTER TABLE `tags_posts`
  ADD CONSTRAINT `tags_posts_ibfk_1` FOREIGN KEY (`ID_POST`) REFERENCES `posts` (`ID_POST`),
  ADD CONSTRAINT `tags_posts_ibfk_2` FOREIGN KEY (`ID_TAG`) REFERENCES `tags` (`ID_TAG`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
