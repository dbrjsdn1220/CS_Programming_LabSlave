USE bookdb

CREATE TABLE `books` (
  `book_id` bigint NOT NULL AUTO_INCREMENT,
  `title` varchar(255) COLLATE utf8mb3_bin NOT NULL,
  `author` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `category` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_bin DEFAULT '미정',
  `copy_count` int DEFAULT '1',
  PRIMARY KEY (`book_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_bin

CREATE TABLE `copy_books` (
  `copyBook_id` bigint NOT NULL,
  `book_id` bigint DEFAULT NULL,
  `alive` tinyint DEFAULT '1',
  `buyDate` date DEFAULT NULL,
  PRIMARY KEY (`copyBook_id`),
  KEY `Books_id_FK_idx` (`book_id`),
  CONSTRAINT `Books_id_FK` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_bin

CREATE TABLE `students` (
  `student_id` int NOT NULL,
  `name` varchar(50) COLLATE utf8mb3_bin DEFAULT NULL,
  `nowCount` int DEFAULT '0',
  `maxCount` int DEFAULT '2',
  `loan_whether` tinyint DEFAULT '1',
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_bin

CREATE TABLE `loans` (
  `loan_id` bigint NOT NULL AUTO_INCREMENT,
  `copyBook_id` bigint DEFAULT NULL,
  `student_id` int DEFAULT NULL,
  `start_date` date NOT NULL,
  `end_date` date DEFAULT NULL,
  `extend` tinyint DEFAULT '0',
  PRIMARY KEY (`loan_id`),
  KEY `CopyBook_id_FK_idx` (`copyBook_id`),
  KEY `Student_id_FK_idx` (`student_id`),
  CONSTRAINT `CopyBook_id_FK` FOREIGN KEY (`copyBook_id`) REFERENCES `copy_books` (`copyBook_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Student_id_FK` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_bin

