-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 23, 2021 at 01:15 PM
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
(1, 'Category 1', '', NULL),
(2, 'Category 2', NULL, NULL),
(3, 'Category 3', '', NULL),
(4, 'Category 4', '', NULL),
(5, 'Category 5', '', NULL),
(6, 'test1', 'testing', NULL),
(7, 'cat1233', '', NULL);

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
(0, 123, 0, 1, '2021-05-23 11:11:14'),
(5, 54545454, 0, 1, '2021-05-19 21:49:02'),
(7, 471778, 0, 1, '2021-05-23 03:48:45');

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
(31, 5, 1, 1, 5),
(37, 7, 10, 1, 0),
(43, 0, 1, 3, 5);

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
(1, '12345', 'Product 1', '', 0, 5, 1, NULL),
(2, '544554', 'Product 2', '', 12, 10, 2, '0000-00-00 00:00:00'),
(3, '5555', 'Product 3', '', 33, 22, 1, NULL),
(8, '111', 'Product 4', '', 10, 55, 1, '0000-00-00 00:00:00'),
(9, '111', 'Product 5', '', 13, 0, 1, NULL),
(10, '435', 'Product 6', '', 1, 0, 3, NULL),
(11, '7687678', 'Product 7', '', 0, 12, 1, NULL),
(12, '1221', 'Product 8', '', 0, 55, 3, '0000-00-00 00:00:00'),
(13, 'code 77', 'test 77', 'testing', 0, -67, 7, NULL);

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
(25, 1, 3, 1, 'added', '2021-05-23 03:11:42'),
(26, 9, 5, 1, 'added', '2021-05-23 03:11:42'),
(27, 9, 1, 1, 'added', '2021-05-23 03:38:37'),
(28, 10, 1, 1, 'added', '2021-05-23 03:38:37'),
(29, 3, 1, 1, 'added', '2021-05-23 03:39:20'),
(30, 10, 1, 1, 'added', '2021-05-23 03:40:19'),
(31, 3, 33, 1, 'subtracted', '2021-05-23 03:48:25'),
(32, 10, 2, 1, 'subtracted', '2021-05-23 03:48:31'),
(33, 3, 32, 1, 'added', '2021-05-23 03:48:36'),
(34, 10, 1, 1, 'added', '2021-05-23 03:48:41'),
(35, 3, 0, 1, 'added', '2021-05-23 03:48:45'),
(36, 10, 0, 1, 'added', '2021-05-23 03:48:45'),
(37, 1, 2, 1, 'subtracted', '2021-05-23 09:10:24'),
(38, 3, 2, 1, 'subtracted', '2021-05-23 09:10:32'),
(39, 3, 1, 1, 'added', '2021-05-23 09:10:38'),
(40, 3, 1, 1, 'added', '2021-05-23 09:10:43'),
(41, 1, 0, 1, 'added', '2021-05-23 09:10:50'),
(42, 1, 2, 1, 'added', '2021-05-23 09:11:16'),
(43, 3, 1, 1, 'subtracted', '2021-05-23 09:11:24'),
(44, 3, 2, 1, 'added', '2021-05-23 09:11:28'),
(45, 10, 1, 1, 'subtracted', '2021-05-23 09:11:36'),
(46, 10, 1, 1, 'added', '2021-05-23 09:11:39'),
(47, 9, 2, 1, 'added', '2021-05-23 10:53:03'),
(48, 9, 5, 1, 'added', '2021-05-23 10:53:03'),
(49, 1, 3, 1, 'subtracted', '2021-05-23 11:11:33');

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
(1, 'super_admin', 'Aya', 'secret', 'super_admin', '2021-05-05 05:28:01', NULL),
(4, 'israa', 'israa', 'secret', 'sales_employee', '2021-05-21 20:31:03', NULL),
(5, 'jannat', 'jannat', 'secre', 'super_admin', '2021-05-23 02:54:20', NULL);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `order_items`
--
ALTER TABLE `order_items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `stock_history`
--
ALTER TABLE `stock_history`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

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
