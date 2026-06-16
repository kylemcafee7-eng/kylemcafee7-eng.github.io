-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 16, 2026 at 10:48 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `collectors_curator`
--

-- --------------------------------------------------------

--
-- Table structure for table `inventory_items`
--

CREATE TABLE `inventory_items` (
  `item_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `vendor_id` int(11) DEFAULT NULL,
  `item_type` varchar(50) NOT NULL,
  `name` varchar(150) NOT NULL,
  `game_name` varchar(100) DEFAULT NULL,
  `set_name` varchar(100) DEFAULT NULL,
  `rarity` varchar(50) DEFAULT NULL,
  `condition` varchar(50) DEFAULT NULL,
  `quantity` int(11) NOT NULL,
  `cost` decimal(10,2) DEFAULT NULL,
  `market_value` decimal(10,2) DEFAULT NULL,
  `image_path` varchar(255) DEFAULT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp(),
  `annual_demand` int(11) DEFAULT NULL,
  `holding_cost` decimal(10,2) DEFAULT NULL,
  `ordering_cost` decimal(10,2) DEFAULT NULL,
  `lead_time_days` int(11) DEFAULT NULL,
  `daily_usage_rate` decimal(10,2) DEFAULT NULL,
  `eoq` decimal(10,2) DEFAULT NULL,
  `rop` decimal(10,2) DEFAULT NULL,
  `itr` decimal(10,2) DEFAULT NULL,
  `demand_rate` decimal(10,2) DEFAULT NULL,
  `cogs` decimal(10,2) DEFAULT NULL,
  `beginning_inventory` decimal(10,2) DEFAULT NULL,
  `ending_inventory` decimal(10,2) DEFAULT NULL,
  `vendor` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inventory_items`
--

INSERT INTO `inventory_items` (`item_id`, `user_id`, `vendor_id`, `item_type`, `name`, `game_name`, `set_name`, `rarity`, `condition`, `quantity`, `cost`, `market_value`, `image_path`, `date_added`, `annual_demand`, `holding_cost`, `ordering_cost`, `lead_time_days`, `daily_usage_rate`, `eoq`, `rop`, `itr`, `demand_rate`, `cogs`, `beginning_inventory`, `ending_inventory`, `vendor`) VALUES
(1, 3, NULL, 'Card', 'Gold Rushes', 'Riches and Rings', 'Historic Sins', 'Common', 'Lihgtly Played', 2, 12.00, 15.00, 'C:\\Users\\kylem\\Downloads\\Screenshot 2026-05-13 231827.png', '2026-05-10 00:35:45', 14, 22.00, 43.00, 10, NULL, 7.40, 110.00, 22.33, 11.00, 67.00, 4.00, 2.00, 'Carl Carlson'),
(3, 3, NULL, 'Video Game', 'Wraight of the Wiggles', 'N/A', 'N/A', 'N/A', 'Poor', 888, 1.00, 500.00, 'C:\\Users\\kylem\\Downloads\\Screenshot 2026-05-08 001852.png', '2026-05-14 21:43:43', 200, 10.00, 30.00, 8, NULL, 34.64, 40.00, 0.02, 5.00, 15.00, 1000.00, 888.00, 'Harold Company'),
(4, 3, NULL, 'Card', 'Draw 4', 'Uno', 'Colorful Cards', 'Common', 'Good', 52, 0.99, 1.50, 'C:\\Users\\kylem\\Downloads\\Screenshot 2026-05-13 231827.png', '2026-05-14 23:05:50', 5, 5.00, 5.00, 4, NULL, 3.16, 224.00, 0.11, 56.00, 6.00, 60.00, 52.00, '');

-- --------------------------------------------------------

--
-- Table structure for table `restock_recommendations`
--

CREATE TABLE `restock_recommendations` (
  `item_id` int(11) NOT NULL,
  `eoq` int(11) DEFAULT NULL,
  `reorder_point` int(11) DEFAULT NULL,
  `turnover_rate` decimal(10,2) DEFAULT NULL,
  `last_calculated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `sales_usage_history`
--

CREATE TABLE `sales_usage_history` (
  `history_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `quantity_used` int(11) NOT NULL,
  `date_used` datetime NOT NULL DEFAULT current_timestamp(),
  `notes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `failed_attempts` int(11) NOT NULL DEFAULT 0,
  `locked_until` datetime DEFAULT NULL,
  `role` varchar(20) NOT NULL DEFAULT 'standard'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password_hash`, `failed_attempts`, `locked_until`, `role`) VALUES
(1, 'admin', 'ecd71870d1963316a97e3ac3408c9835ad8cf0f3c1a5a5a5d8f5d8f5d8f5d8f5', 0, NULL, 'standard'),
(2, 'test user', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0, NULL, 'standard'),
(3, 'kyle', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0, NULL, 'admin'),
(4, 'user', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', 0, NULL, 'standard');

-- --------------------------------------------------------

--
-- Table structure for table `vendors`
--

CREATE TABLE `vendors` (
  `vendor_id` int(11) NOT NULL,
  `vendor_name` varchar(100) NOT NULL,
  `contact_info` varchar(255) DEFAULT NULL,
  `website` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `inventory_items`
--
ALTER TABLE `inventory_items`
  ADD PRIMARY KEY (`item_id`),
  ADD KEY `fk_inventory_user` (`user_id`);

--
-- Indexes for table `restock_recommendations`
--
ALTER TABLE `restock_recommendations`
  ADD PRIMARY KEY (`item_id`);

--
-- Indexes for table `sales_usage_history`
--
ALTER TABLE `sales_usage_history`
  ADD PRIMARY KEY (`history_id`),
  ADD KEY `fk_usage_item` (`item_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `vendors`
--
ALTER TABLE `vendors`
  ADD PRIMARY KEY (`vendor_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `inventory_items`
--
ALTER TABLE `inventory_items`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `sales_usage_history`
--
ALTER TABLE `sales_usage_history`
  MODIFY `history_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `vendors`
--
ALTER TABLE `vendors`
  MODIFY `vendor_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `inventory_items`
--
ALTER TABLE `inventory_items`
  ADD CONSTRAINT `fk_inventory_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE;

--
-- Constraints for table `restock_recommendations`
--
ALTER TABLE `restock_recommendations`
  ADD CONSTRAINT `fk_restock_item` FOREIGN KEY (`item_id`) REFERENCES `inventory_items` (`item_id`) ON DELETE CASCADE;

--
-- Constraints for table `sales_usage_history`
--
ALTER TABLE `sales_usage_history`
  ADD CONSTRAINT `fk_usage_item` FOREIGN KEY (`item_id`) REFERENCES `inventory_items` (`item_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
