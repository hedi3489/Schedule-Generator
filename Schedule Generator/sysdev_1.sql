-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 11, 2023 at 10:29 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sysdev`
--

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `courseId` int(11) NOT NULL,
  `teacherId` int(11) NOT NULL,
  `courseName` int(50) NOT NULL,
  `roomId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `day`
--

CREATE TABLE `day` (
  `dayId` int(11) NOT NULL,
  `lesson1` int(11) NOT NULL,
  `lesson2` int(11) NOT NULL,
  `lesson3` int(11) NOT NULL,
  `lesson4` int(11) NOT NULL,
  `lesson5` int(11) NOT NULL,
  `lesson6` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `duration`
--

CREATE TABLE `duration` (
  `durationId` int(11) NOT NULL,
  `beginning` int(11) NOT NULL,
  `end` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `lesson`
--

CREATE TABLE `lesson` (
  `lessonId` int(11) NOT NULL,
  `courseId` int(11) NOT NULL,
  `durationId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `roomId` int(11) NOT NULL,
  `type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `scheduleId` int(11) NOT NULL,
  `Mon` int(11) NOT NULL,
  `Tue` int(11) NOT NULL,
  `Wed` int(11) NOT NULL,
  `Thu` int(11) NOT NULL,
  `Fri` int(11) NOT NULL,
  `Sat` int(11) NOT NULL,
  `Sun` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `teacherId` int(11) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `teacherAvailability` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `teacheravailability`
--

CREATE TABLE `teacheravailability` (
  `teacherAvailabilityId` int(11) NOT NULL,
  `Mon` int(11) NOT NULL,
  `Tue` int(11) NOT NULL,
  `Wed` int(11) NOT NULL,
  `Thu` int(11) NOT NULL,
  `Fri` int(11) NOT NULL,
  `Sat` int(11) NOT NULL,
  `Sun` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`courseId`),
  ADD KEY `teacherId` (`teacherId`),
  ADD KEY `roomId` (`roomId`);

--
-- Indexes for table `day`
--
ALTER TABLE `day`
  ADD PRIMARY KEY (`dayId`),
  ADD KEY `lesson1` (`lesson1`),
  ADD KEY `lesson2` (`lesson2`),
  ADD KEY `lesson3` (`lesson3`),
  ADD KEY `lesson4` (`lesson4`),
  ADD KEY `lesson5` (`lesson5`),
  ADD KEY `lesson6` (`lesson6`);

--
-- Indexes for table `duration`
--
ALTER TABLE `duration`
  ADD PRIMARY KEY (`durationId`);

--
-- Indexes for table `lesson`
--
ALTER TABLE `lesson`
  ADD PRIMARY KEY (`lessonId`),
  ADD KEY `courseId` (`courseId`),
  ADD KEY `durationId` (`durationId`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`roomId`);

--
-- Indexes for table `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`scheduleId`),
  ADD KEY `Mon` (`Mon`),
  ADD KEY `Tue` (`Tue`),
  ADD KEY `Wed` (`Wed`),
  ADD KEY `Thu` (`Thu`),
  ADD KEY `Fri` (`Fri`),
  ADD KEY `Sat` (`Sat`),
  ADD KEY `Sun` (`Sun`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`teacherId`),
  ADD KEY `teacher_ibfk_1` (`teacherAvailability`);

--
-- Indexes for table `teacheravailability`
--
ALTER TABLE `teacheravailability`
  ADD PRIMARY KEY (`teacherAvailabilityId`),
  ADD KEY `Mon` (`Mon`),
  ADD KEY `Tue` (`Tue`),
  ADD KEY `Wed` (`Wed`),
  ADD KEY `Thu` (`Thu`),
  ADD KEY `Fri` (`Fri`),
  ADD KEY `Sat` (`Sat`),
  ADD KEY `Sun` (`Sun`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `course`
--
ALTER TABLE `course`
  ADD CONSTRAINT `course_ibfk_1` FOREIGN KEY (`teacherId`) REFERENCES `teacher` (`teacherId`),
  ADD CONSTRAINT `course_ibfk_2` FOREIGN KEY (`roomId`) REFERENCES `room` (`roomId`);

--
-- Constraints for table `day`
--
ALTER TABLE `day`
  ADD CONSTRAINT `day_ibfk_1` FOREIGN KEY (`lesson1`) REFERENCES `lesson` (`lessonId`),
  ADD CONSTRAINT `day_ibfk_2` FOREIGN KEY (`lesson2`) REFERENCES `lesson` (`lessonId`),
  ADD CONSTRAINT `day_ibfk_3` FOREIGN KEY (`lesson3`) REFERENCES `lesson` (`lessonId`),
  ADD CONSTRAINT `day_ibfk_4` FOREIGN KEY (`lesson4`) REFERENCES `lesson` (`lessonId`),
  ADD CONSTRAINT `day_ibfk_5` FOREIGN KEY (`lesson4`) REFERENCES `lesson` (`lessonId`),
  ADD CONSTRAINT `day_ibfk_6` FOREIGN KEY (`lesson5`) REFERENCES `lesson` (`lessonId`),
  ADD CONSTRAINT `day_ibfk_7` FOREIGN KEY (`lesson6`) REFERENCES `lesson` (`lessonId`);

--
-- Constraints for table `lesson`
--
ALTER TABLE `lesson`
  ADD CONSTRAINT `lesson_ibfk_1` FOREIGN KEY (`courseId`) REFERENCES `course` (`courseId`),
  ADD CONSTRAINT `lesson_ibfk_2` FOREIGN KEY (`durationId`) REFERENCES `duration` (`durationId`);

--
-- Constraints for table `schedule`
--
ALTER TABLE `schedule`
  ADD CONSTRAINT `schedule_ibfk_1` FOREIGN KEY (`Mon`) REFERENCES `day` (`dayId`),
  ADD CONSTRAINT `schedule_ibfk_2` FOREIGN KEY (`Tue`) REFERENCES `day` (`dayId`),
  ADD CONSTRAINT `schedule_ibfk_3` FOREIGN KEY (`Wed`) REFERENCES `day` (`dayId`),
  ADD CONSTRAINT `schedule_ibfk_4` FOREIGN KEY (`Thu`) REFERENCES `day` (`dayId`),
  ADD CONSTRAINT `schedule_ibfk_5` FOREIGN KEY (`Fri`) REFERENCES `day` (`dayId`),
  ADD CONSTRAINT `schedule_ibfk_6` FOREIGN KEY (`Sat`) REFERENCES `day` (`dayId`),
  ADD CONSTRAINT `schedule_ibfk_7` FOREIGN KEY (`Sun`) REFERENCES `day` (`dayId`);

--
-- Constraints for table `teacher`
--
ALTER TABLE `teacher`
  ADD CONSTRAINT `teacher_ibfk_1` FOREIGN KEY (`teacherAvailability`) REFERENCES `teacheravailability` (`teacheravailabilityId`);

--
-- Constraints for table `teacheravailability`
--
ALTER TABLE `teacheravailability`
  ADD CONSTRAINT `teacheravailability_ibfk_1` FOREIGN KEY (`Mon`) REFERENCES `duration` (`durationId`),
  ADD CONSTRAINT `teacheravailability_ibfk_2` FOREIGN KEY (`Tue`) REFERENCES `duration` (`durationId`),
  ADD CONSTRAINT `teacheravailability_ibfk_3` FOREIGN KEY (`Wed`) REFERENCES `duration` (`durationId`),
  ADD CONSTRAINT `teacheravailability_ibfk_4` FOREIGN KEY (`Thu`) REFERENCES `duration` (`durationId`),
  ADD CONSTRAINT `teacheravailability_ibfk_5` FOREIGN KEY (`Fri`) REFERENCES `duration` (`durationId`),
  ADD CONSTRAINT `teacheravailability_ibfk_6` FOREIGN KEY (`Sat`) REFERENCES `duration` (`durationId`),
  ADD CONSTRAINT `teacheravailability_ibfk_7` FOREIGN KEY (`Sun`) REFERENCES `duration` (`durationId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
