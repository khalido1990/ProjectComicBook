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
(2, 'Mark Waid', 'Mark Waid is a famous comic book creator known for his strong work at both DC Comics and Marvel Comics. He revolutionized Wally West as the Flash as well as writing Kingdom Come, 52 and Superman: Birthright. Waid also penned the titles of Fantastic Four, '),
(3, 'Gijs Janssen', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(4, 'Thomas Johnsen', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(5, 'Mark Janssen', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(6, 'Daan Visser', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(7, 'Daniel Visser', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(8, 'Noud Miller', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(9, 'Thomas Jones', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(10, 'Gijs Willams', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(11, 'Gijs Visser', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(12, 'Iris Smit', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(13, 'Ties De Vries', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(14, 'Irma Jones', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(15, 'Daniel De Jong', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(16, 'Daniel De Jong', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(17, 'Thijs Janssen', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(18, 'Thomas Smit', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(19, 'Daniel Smit', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(20, 'Thijs Brown', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(21, 'Iris Meijer', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(22, 'Thomas Willams', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.');

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
  `isbn` int(11) DEFAULT NULL,
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
(1, 1, 2, 1, 'Batman / Superman: World\'s Finest #1', '2022-03-15', 2147483647, 'Fysiek', 'test', 'THE DEVIL NEZHA, CHAPTER ONE: DOOMED\nThe Dark Knight. The Man of Steel. They are the two finest superheroes that the world has ever known…and they’re together again in an epic new series from the legendary talents of Mark Waid and Dan Mora! In the not-to', 32, 1),
(2, 2, 3, 18, 'BatMan #28', '1969-07-13', 94123, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 67, 0),
(3, 7, 12, 14, 'SuperWomen #93', '1933-04-19', 17257, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 165, 0),
(4, 6, 3, 22, 'SpiderWomen #12', '1946-11-23', 74117, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 31, 0),
(5, 2, 4, 13, 'BatMan #59', '2015-04-16', 63843, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 202, 0),
(6, 8, 4, 11, 'SuperMan #53', '1901-07-16', 13463, 'Digitaal', NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 280, 0),
(7, 6, 9, 20, 'SpiderWomen #80', '1881-07-06', 56117, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 248, 0),
(8, 7, 20, 17, 'SuperWomen #70', '1908-05-19', 48605, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 276, 1),
(9, 9, 3, 7, 'RhinoWomen #96', '2004-05-06', 63761, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 152, 1),
(10, 6, 10, 9, 'SpiderWomen #74', '1882-08-12', 45454, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 157, 1),
(11, 2, 4, 15, 'BatMan #74', '1991-08-26', 93116, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 43, 0),
(12, 3, 18, 13, 'AntMan #20', '1941-08-22', 64743, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 212, 1),
(13, 5, 10, 14, 'AntWomen #85', '1952-05-10', 38504, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 62, 0),
(14, 7, 22, 7, 'SuperWomen #27', '1992-02-22', 20299, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 196, 1),
(15, 2, 4, 19, 'BatMan #93', '1981-09-06', 12309, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 28, 1),
(16, 8, 8, 12, 'SuperMan #22', '1927-11-07', 48359, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 125, 0),
(17, 5, 21, 13, 'AntWomen #22', '1956-01-12', 53324, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 167, 0),
(18, 3, 18, 9, 'AntMan #38', '1962-11-11', 68611, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 132, 1),
(19, 8, 9, 13, 'SuperMan #10', '1940-07-04', 15309, NULL, NULL, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 297, 0);

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
(1, 'Dan Mora', 'Dan Mora is an artist whose work includes Buffyverse comics from Boom! Studios.'),
(3, 'Noud Davis', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(4, 'Ties Meijer', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(5, 'Fleur Miller', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(6, 'Irma De Vries', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(7, 'Thomas Miller', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(8, 'Gijs De Jong', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(9, 'Ties Johnsen', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(10, 'Daan De Vries', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(11, 'Daniel Willams', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(12, 'Gijs Smit', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(13, 'Thijs Johnsen', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(14, 'Teun Johnsen', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(15, 'Fleur Smith', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(16, 'Thomas Meijer', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(17, 'Ties Miller', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(18, 'Teun Miller', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(19, 'Irma Jones', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(20, 'Daniel Davis', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(21, 'Thomas Smit', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.'),
(22, 'Daan De Vries', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.');

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
(1, 'Batman / Superman: World\'s Finest', 'The Dark Knight. The Man of Steel. They are the two finest superheroes that the world has ever known...and they’re together again in an epic new series from the legendary talents of Mark Waid and Dan Mora!\r\n\r\nIn the not-too-distant past, Superman’s powers', 0),
(2, 'BatMan', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 0),
(3, 'AntMan', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 1),
(4, 'RhinoMan', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 0),
(5, 'AntWomen', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 1),
(6, 'SpiderWomen', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc.', 0),
(7, 'SuperWomen', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc', 1),
(8, 'SuperMan', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc', 1),
(9, 'RhinoWomen', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel ligula in tellus imperdiet tincidunt. Fusce in lorem non lorem faucibus consequat vel eget enim. Nunc ut elit id leo lacinia rutrum vel non est. Vivamus vel mollis lorem. Fusce eros nunc', 0);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userID` int(11) NOT NULL,
  `role_ID` int(11) NOT NULL,
  `name` varchar(25) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(255) NOT NULL
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
  MODIFY `authorID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `collectioncomicbook`
--
ALTER TABLE `collectioncomicbook`
  MODIFY `collectionID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `comicbook`
--
ALTER TABLE `comicbook`
  MODIFY `comicbookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `illustrator`
--
ALTER TABLE `illustrator`
  MODIFY `illustratorID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `role_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `serie`
--
ALTER TABLE `serie`
  MODIFY `serie_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

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
