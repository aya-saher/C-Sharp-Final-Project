-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 22, 2021 at 05:14 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `stock_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `description` text DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`id`, `name`, `description`, `deleted_at`) VALUES
(1, 'Test', NULL, NULL),
(2, 'Test 2', NULL, '0000-00-00 00:00:00'),
(3, 'test 4', '', NULL),
(4, 'test 6', '', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `reference_number` int(11) NOT NULL,
  `total` float NOT NULL DEFAULT 0,
  `user_id` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `reference_number`, `total`, `user_id`, `created_at`) VALUES
(5, 545455, 835, 1, '2021-05-19 21:49:02'),
(13, 285624, 2435, 1, '2021-05-20 17:48:20');

--
-- Triggers `orders`
--
DELIMITER $$
CREATE TRIGGER `before_delete_order_update_product_quantity` BEFORE DELETE ON `orders` FOR EACH ROW BEGIN
  DECLARE v1, v2, done INT;
  DECLARE curs CURSOR FOR SELECT product_id, quantity FROM order_items WHERE order_id = OLD.id;
  DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

 OPEN curs;
    read_loop: LOOP
      FETCH curs INTO v1, v2;
        IF done THEN
          LEAVE read_loop;
        END IF;

      
    INSERT INTO stock_history(product_id, quantity, type, user_id) VALUES (v1, v2, "added", OLD.user_id);

    END LOOP;
    CLOSE curs;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `order_items`
--

CREATE TABLE `order_items` (
  `id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT 0,
  `price` float NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `order_items`
--

INSERT INTO `order_items` (`id`, `order_id`, `product_id`, `quantity`, `price`) VALUES
(32, 5, 3, 3, 22),
(34, 5, 8, 1, 55),
(35, 5, 3, 32, 22),
(36, 5, 8, 10, 55),
(47, 13, 8, 1, 55),
(48, 13, 11, 69, 10),
(49, 13, 8, 18, 55),
(50, 13, 11, 70, 10);

--
-- Triggers `order_items`
--
DELIMITER $$
CREATE TRIGGER `after_delete_order_items_update_product_quantity` BEFORE DELETE ON `order_items` FOR EACH ROW BEGIN
DECLARE order_user_id INT;

SET order_user_id = (SELECT user_id FROM orders WHERE id = OLD.order_id);

INSERT INTO stock_history(product_id, quantity, type, user_id) VALUES (OLD.product_id, OLD.quantity, "added", order_user_id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `after_update_order_items_update_product_quantity` BEFORE UPDATE ON `order_items` FOR EACH ROW BEGIN
DECLARE order_user_id, difference_quantity INT;

SET order_user_id = (SELECT user_id FROM orders WHERE id = OLD.order_id);


IF(NEW.quantity > OLD.quantity) THEN
SET difference_quantity = NEW.quantity - OLD.quantity;
INSERT INTO stock_history(product_id, quantity, type, user_id) VALUES (OLD.product_id, difference_quantity, "subtracted", order_user_id);
ELSE
SET difference_quantity = OLD.quantity - NEW.quantity;
INSERT INTO stock_history(product_id, quantity, type, user_id) VALUES (OLD.product_id, difference_quantity, "added", order_user_id);
END IF;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `stock_history` AFTER INSERT ON `order_items` FOR EACH ROW BEGIN
DECLARE order_user_id INT;
SET order_user_id = (SELECT user_id FROM orders WHERE id = NEW.order_id);
INSERT INTO stock_history(product_id, quantity, type, user_id) VALUES (NEW.product_id, NEW.quantity, "subtracted", order_user_id);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `code` varchar(20) NOT NULL,
  `name` varchar(50) NOT NULL,
  `description` text NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT 0,
  `price` float NOT NULL DEFAULT 0,
  `category_id` int(11) NOT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`id`, `code`, `name`, `description`, `quantity`, `price`, `category_id`, `deleted_at`) VALUES
(1, '12345', 'Product 1', '', 11, 5, 1, '0000-00-00 00:00:00'),
(2, '544554', 'Product 2', '', 12, 10, 2, '0000-00-00 00:00:00'),
(3, '98765', 'Product 3', '', 17, 22, 3, '0000-00-00 00:00:00'),
(8, '111', 'jhj', '', 101, 55, 1, NULL),
(9, '111', 'sds2', '', 10, 0, 1, NULL),
(10, '435', 'ثقف', '', 0, 0, 2, '0000-00-00 00:00:00'),
(11, '1233', 'sw', 'ww', -59, 10, 1, NULL),
(12, '1234', 'product 1', '', 0, 10, 3, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `stock_history`
--

CREATE TABLE `stock_history` (
  `id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT 0,
  `user_id` int(11) NOT NULL,
  `type` enum('added','subtracted') NOT NULL DEFAULT 'added',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `stock_history`
--

INSERT INTO `stock_history` (`id`, `product_id`, `quantity`, `user_id`, `type`, `created_at`) VALUES
(5, 9, 1, 1, 'added', '2021-05-05 05:28:17'),
(6, 3, 1, 1, 'added', '2021-05-05 05:28:17'),
(7, 1, 10, 1, 'added', '2021-05-05 05:30:27'),
(8, 8, 0, 1, 'subtracted', '2021-05-05 06:31:37'),
(9, 3, 2, 1, 'subtracted', '2021-05-05 06:31:57'),
(10, 3, 2, 1, 'subtracted', '2021-05-05 06:31:57'),
(11, 1, 1, 1, 'added', '2021-05-19 19:40:17'),
(12, 8, 1, 1, 'added', '2021-05-19 19:40:17'),
(13, 3, 3, 1, 'subtracted', '2021-05-19 20:53:00'),
(14, 3, 3, 1, 'added', '2021-05-19 20:53:32'),
(15, 8, 4, 1, 'subtracted', '2021-05-19 20:58:56'),
(16, 9, 2, 1, 'subtracted', '2021-05-19 21:01:29'),
(17, 2, 4, 1, 'subtracted', '2021-05-19 21:01:29'),
(18, 9, 5, 1, 'subtracted', '2021-05-19 21:03:36'),
(19, 2, 4, 1, 'subtracted', '2021-05-19 21:03:36'),
(20, 8, 5, 1, 'subtracted', '2021-05-19 21:13:29'),
(21, 2, 2, 1, 'subtracted', '2021-05-19 21:13:29'),
(22, 8, 5, 1, 'added', '2021-05-19 21:15:36'),
(23, 2, 2, 1, 'added', '2021-05-19 21:15:36'),
(24, 1, 1, 1, 'subtracted', '2021-05-19 21:52:10'),
(25, 3, 3, 1, 'subtracted', '2021-05-19 22:19:48'),
(26, 8, 10, 1, 'subtracted', '2021-05-19 22:19:53'),
(27, 8, 9, 1, 'added', '2021-05-19 22:20:00'),
(28, 8, 1, 1, 'added', '2021-05-19 22:20:02'),
(29, 8, 1, 1, 'subtracted', '2021-05-19 22:20:07'),
(30, 3, 0, 1, 'added', '2021-05-19 22:20:09'),
(31, 8, 0, 1, 'added', '2021-05-19 22:20:09'),
(32, 3, 32, 1, 'subtracted', '2021-05-19 22:20:15'),
(33, 3, 0, 1, 'added', '2021-05-19 22:20:16'),
(34, 1, 1, 1, 'subtracted', '2021-05-19 22:20:52'),
(35, 1, 2, 1, 'added', '2021-05-19 22:20:59'),
(36, 8, 10, 1, 'subtracted', '2021-05-19 22:21:30'),
(37, 8, 0, 1, 'added', '2021-05-19 22:21:33'),
(38, 1, 1, 1, 'subtracted', '2021-05-19 22:25:01'),
(39, 1, 1, 1, 'subtracted', '2021-05-19 22:25:05'),
(40, 1, 0, 1, 'added', '2021-05-19 22:25:10'),
(41, 1, 0, 1, 'added', '2021-05-19 22:25:10'),
(42, 1, 1, 1, 'subtracted', '2021-05-19 22:25:17'),
(43, 1, 1, 1, 'added', '2021-05-19 22:25:21'),
(44, 1, 1, 1, 'subtracted', '2021-05-19 22:25:24'),
(45, 11, 5, 1, 'subtracted', '2021-05-20 13:36:51'),
(46, 1, 0, 1, 'added', '2021-05-20 13:37:11'),
(47, 11, 0, 1, 'added', '2021-05-20 13:37:11'),
(48, 11, 5, 1, 'subtracted', '2021-05-20 13:37:21'),
(49, 11, 2, 1, 'added', '2021-05-20 13:37:26'),
(50, 11, 3, 1, 'added', '2021-05-20 13:37:28'),
(51, 11, 5, 1, 'subtracted', '2021-05-20 13:37:38'),
(52, 11, 5, 1, 'subtracted', '2021-05-20 13:37:44'),
(65, 1, 10, 1, 'added', '2021-05-20 13:51:22'),
(66, 3, 20, 1, 'added', '2021-05-20 13:51:22'),
(67, 3, 16, 1, 'subtracted', '2021-05-20 13:51:45'),
(68, 11, 0, 1, 'added', '2021-05-20 13:51:50'),
(69, 11, 0, 1, 'added', '2021-05-20 13:51:50'),
(70, 3, 0, 1, 'added', '2021-05-20 13:51:50'),
(71, 3, 11, 1, 'added', '2021-05-20 13:52:08'),
(72, 11, 5, 1, 'added', '2021-05-20 13:52:35'),
(73, 1, 1, 1, 'added', '2021-05-20 13:52:44'),
(75, 8, 20, 1, 'subtracted', '2021-05-20 17:35:21'),
(76, 8, 18, 1, 'added', '2021-05-20 17:35:26'),
(77, 8, 1, 1, 'subtracted', '2021-05-20 17:46:25'),
(78, 11, 69, 1, 'subtracted', '2021-05-20 17:46:52'),
(79, 8, 1, 1, 'added', '2021-05-20 17:47:00'),
(80, 8, 1, 1, 'added', '2021-05-20 17:47:03'),
(81, 8, 18, 1, 'subtracted', '2021-05-20 17:47:14'),
(82, 11, 70, 1, 'subtracted', '2021-05-20 17:47:19'),
(83, 8, 0, 1, 'added', '2021-05-20 17:48:20'),
(84, 11, 0, 1, 'added', '2021-05-20 17:48:20'),
(85, 8, 0, 1, 'added', '2021-05-20 17:48:20'),
(86, 11, 0, 1, 'added', '2021-05-20 17:48:20'),
(87, 8, 1, 1, 'subtracted', '2021-05-20 17:48:25'),
(88, 8, 0, 1, 'added', '2021-05-20 17:48:27'),
(91, 11, 5, 1, 'added', '2021-05-20 17:49:37'),
(96, 8, 10, 1, 'subtracted', '2021-05-20 17:55:51'),
(97, 9, 8, 1, 'subtracted', '2021-05-20 17:56:07'),
(98, 8, 10, 1, 'added', '2021-05-20 17:56:11'),
(99, 9, 8, 1, 'added', '2021-05-20 17:56:18'),
(100, 8, 10, 1, 'subtracted', '2021-05-20 17:56:25'),
(101, 9, 1, 1, 'subtracted', '2021-05-20 17:56:31'),
(102, 9, 1, 1, 'added', '2021-05-20 17:56:35'),
(103, 8, 9, 1, 'added', '2021-05-20 17:56:42'),
(104, 8, 0, 1, 'added', '2021-05-20 17:56:49'),
(110, 8, 1, 1, 'subtracted', '2021-05-20 18:03:09'),
(112, 8, 2, 1, 'added', '2021-05-20 18:03:28'),
(113, 11, 5, 1, 'added', '2021-05-20 18:08:33'),
(114, 3, 5, 1, 'added', '2021-05-20 18:08:33'),
(115, 8, 100, 1, 'subtracted', '2021-05-20 21:53:06'),
(116, 8, 100, 1, 'added', '2021-05-20 21:53:12'),
(117, 1, 1, 1, 'subtracted', '2021-05-20 21:53:34'),
(118, 1, 1, 1, 'added', '2021-05-20 21:53:42'),
(119, 1, 1, 1, 'added', '2021-05-20 21:53:56'),
(120, 1, 1, 1, 'added', '2021-05-20 21:57:00'),
(121, 8, 1, 1, 'added', '2021-05-20 22:09:58'),
(122, 8, 1, 1, 'subtracted', '2021-05-20 22:13:49'),
(123, 8, 0, 1, 'added', '2021-05-20 22:14:00'),
(124, 8, 1, 1, 'added', '2021-05-20 22:16:11'),
(125, 9, 10, 1, 'subtracted', '2021-05-20 22:18:33'),
(126, 8, 101, 1, 'subtracted', '2021-05-20 22:18:51'),
(127, 9, 10, 1, 'added', '2021-05-20 22:18:56'),
(128, 9, 1, 1, 'subtracted', '2021-05-20 22:23:18'),
(129, 8, 101, 1, 'added', '2021-05-20 22:30:45'),
(130, 9, 1, 1, 'added', '2021-05-20 22:30:45');

--
-- Triggers `stock_history`
--
DELIMITER $$
CREATE TRIGGER `update_product_quantity` AFTER INSERT ON `stock_history` FOR EACH ROW BEGIN
DECLARE current_quantity INT;

SET current_quantity = (SELECT quantity FROM products WHERE id = NEW.product_id);

IF(NEW.type LIKE "added") THEN
UPDATE products SET quantity = (current_quantity + NEW.quantity) WHERE id = NEW.product_id;
ELSE
UPDATE products SET quantity = (current_quantity - NEW.quantity) WHERE id = NEW.product_id;
END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `name` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('sales_employee','warehouse_employee','super_admin') NOT NULL,
  `activated_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `name`, `password`, `role`, `activated_at`, `deleted_at`) VALUES
(1, 'aya', 'aya', 'aya', 'super_admin', '2021-05-05 05:28:01', '2021-05-05 05:28:01'),
(2, 'aya_', 'aya', 'aya', 'super_admin', '2021-05-21 17:07:19', '0000-00-00 00:00:00'),
(3, 'aya__', 'aya', '12345678', 'super_admin', '2021-05-21 17:09:32', '0000-00-00 00:00:00'),
(4, 'aya', 'aya', '12345678', 'super_admin', '2021-05-21 18:43:12', '0000-00-00 00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `order_items`
--
ALTER TABLE `order_items`
  ADD PRIMARY KEY (`id`),
  ADD KEY `product_id` (`product_id`),
  ADD KEY `order_id` (`order_id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`),
  ADD KEY `category_id` (`category_id`);

--
-- Indexes for table `stock_history`
--
ALTER TABLE `stock_history`
  ADD PRIMARY KEY (`id`),
  ADD KEY `product_id` (`product_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `order_items`
--
ALTER TABLE `order_items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `stock_history`
--
ALTER TABLE `stock_history`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=131;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `order_items`
--
ALTER TABLE `order_items`
  ADD CONSTRAINT `order_items_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `order_items_ibfk_3` FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`);

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `categories` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `stock_history`
--
ALTER TABLE `stock_history`
  ADD CONSTRAINT `stock_history_ibfk_1` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `stock_history_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
