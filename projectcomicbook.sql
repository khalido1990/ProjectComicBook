--
-- Database: `projectcomicbook`
--

-- --------------------------------------------------------

--
-- Table structure for table `author`
--

CREATE TABLE `author` (
  `authorID` int(11) NOT NULL,
  `name` varchar(25) NOT NULL,
  `description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `author`
--

INSERT INTO `author` (`authorID`, `name`, `description`) VALUES
(1, 'Stan Lee', 'Stan Lee born Stanley Martin Lieber December 28 1922 was an American comic book writer, editor, publisher, and producer.'),
(2, 'Mark Waid', 'Mark Waid is a famous comic book creator known for his strong work at both DC Comics and Marvel Comics. He revolutionized Wally West as the Flash as well as writing Kingdom Come, 52 and Superman: Birthright. Waid also penned the titles of Fantastic Four, ');

-- --------------------------------------------------------

--
-- Table structure for table `collectioncomicbook`
--

CREATE TABLE `collectioncomicbook` (
  `collectionID` int(11) NOT NULL,
  `comicbookID` int(11) NOT NULL,
  `userID` int(11) NOT NULL,
  `quality` varchar(25) NOT NULL,
  `height` int(11) NOT NULL,
  `rating` int(11) NOT NULL,
  `read` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `comicbook`
--

CREATE TABLE `comicbook` (
  `comicbookID` int(11) NOT NULL,
  `serie_ID` int(11) NOT NULL,
  `authorID` int(11) NOT NULL,
  `illustratorID` int(11) NOT NULL,
  `titel` varchar(255) NOT NULL,
  `release_date` date NOT NULL,
  `isbn` int(255) DEFAULT NULL,
  `type` varchar(25) DEFAULT NULL,
  `cover` varchar(25) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `pages` int(11) NOT NULL,
  `explicit` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `comicbook`
--

INSERT INTO `comicbook` (`comicbookID`, `serie_ID`, `authorID`, `illustratorID`, `titel`, `release_date`, `isbn`, `type`, `cover`, `description`, `pages`, `explicit`) VALUES
(1, 1, 2, 1, 'Batman / Superman: World\'s Finest #1', '2022-03-15', NULL, 'Fysiek', NULL, 'THE DEVIL NEZHA, CHAPTER ONE: DOOMED\nThe Dark Knight. The Man of Steel. They are the two finest superheroes that the world has ever known…and they’re together again in an epic new series from the legendary talents of Mark Waid and Dan Mora! In the not-to', 32, 1);

-- --------------------------------------------------------

--
-- Table structure for table `illustrator`
--

CREATE TABLE `illustrator` (
  `illustratorID` int(11) NOT NULL,
  `name` varchar(25) NOT NULL,
  `description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `illustrator`
--

INSERT INTO `illustrator` (`illustratorID`, `name`, `description`) VALUES
(1, 'Dan Mora', 'Dan Mora is an artist whose work includes Buffyverse comics from Boom! Studios.');

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `role_ID` int(11) NOT NULL,
  `name` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`role_ID`, `name`) VALUES
(1, 'Admin'),
(2, 'Mod'),
(3, 'User');

-- --------------------------------------------------------

--
-- Table structure for table `serie`
--

CREATE TABLE `serie` (
  `serie_ID` int(11) NOT NULL,
  `titel` varchar(255) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  `completed` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `serie`
--

INSERT INTO `serie` (`serie_ID`, `titel`, `description`, `completed`) VALUES
(1, 'Batman / Superman: World\'s Finest', 'The Dark Knight. The Man of Steel. They are the two finest superheroes that the world has ever known...and they’re together again in an epic new series from the legendary talents of Mark Waid and Dan Mora!\r\n\r\nIn the not-too-distant past, Superman’s powers', 0);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userID` int(11) NOT NULL,
  `role_ID` int(11) NOT NULL,
  `name` varchar(25) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `author`
--
ALTER TABLE `author`
  ADD PRIMARY KEY (`authorID`);

--
-- Indexes for table `collectioncomicbook`
--
ALTER TABLE `collectioncomicbook`
  ADD PRIMARY KEY (`collectionID`),
  ADD KEY `Collectioncomicbook_fk0` (`comicbookID`),
  ADD KEY `Collectioncomicbook_fk1` (`userID`);

--
-- Indexes for table `comicbook`
--
ALTER TABLE `comicbook`
  ADD PRIMARY KEY (`comicbookID`),
  ADD UNIQUE KEY `isbn` (`isbn`),
  ADD KEY `Comicbook_fk2` (`illustratorID`),
  ADD KEY `Comicbook_fk0` (`serie_ID`),
  ADD KEY `Comicbook_fk1` (`authorID`);

--
-- Indexes for table `illustrator`
--
ALTER TABLE `illustrator`
  ADD PRIMARY KEY (`illustratorID`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`role_ID`);

--
-- Indexes for table `serie`
--
ALTER TABLE `serie`
  ADD PRIMARY KEY (`serie_ID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userID`),
  ADD UNIQUE KEY `username` (`username`),
  ADD KEY `User_fk0` (`role_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `author`
--
ALTER TABLE `author`
  MODIFY `authorID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `collectioncomicbook`
--
ALTER TABLE `collectioncomicbook`
  MODIFY `collectionID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `comicbook`
--
ALTER TABLE `comicbook`
  MODIFY `comicbookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `illustrator`
--
ALTER TABLE `illustrator`
  MODIFY `illustratorID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `role_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `serie`
--
ALTER TABLE `serie`
  MODIFY `serie_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `collectioncomicbook`
--
ALTER TABLE `collectioncomicbook`
  ADD CONSTRAINT `Collectioncomicbook_fk0` FOREIGN KEY (`comicbookID`) REFERENCES `comicbook` (`comicbookID`),
  ADD CONSTRAINT `Collectioncomicbook_fk1` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`);

--
-- Constraints for table `comicbook`
--
ALTER TABLE `comicbook`
  ADD CONSTRAINT `Comicbook_fk0` FOREIGN KEY (`serie_ID`) REFERENCES `serie` (`serie_ID`),
  ADD CONSTRAINT `Comicbook_fk1` FOREIGN KEY (`authorID`) REFERENCES `author` (`authorID`),
  ADD CONSTRAINT `Comicbook_fk2` FOREIGN KEY (`illustratorID`) REFERENCES `illustrator` (`illustratorID`);

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `User_fk0` FOREIGN KEY (`role_ID`) REFERENCES `role` (`role_ID`);