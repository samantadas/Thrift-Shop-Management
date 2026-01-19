ALTER TABLE bids
ADD user_id INT;


INSERT INTO auctions
(
    prod_id,
    prod_name,
    start_price,
    current_bid,
    highest_bidder,
    start_time,
    end_time,
    status
)
VALUES
(
    101,
    'Nike Air Jordan Retro',
    5000,
    5000,
    NULL,
    GETDATE(),
    DATEADD(HOUR, 2, GETDATE()),
    'Active'
);

INSERT INTO auctions
(prod_id, prod_name, start_price, current_bid, highest_bidder, start_time, end_time, status)
VALUES
(102, 'Rolex Submariner Watch', 8000, 8000, NULL, GETDATE(), DATEADD(HOUR, 3, GETDATE()), 'Active'),

(103, 'Vintage Leather Jacket', 2500, 2500, NULL, GETDATE(), DATEADD(HOUR, 1, GETDATE()), 'Active'),

(104, 'PlayStation 5 (Used)', 45000, 45000, NULL, GETDATE(), DATEADD(DAY, 1, GETDATE()), 'Active');

ALTER TABLE bids
DROP COLUMN user_id;
