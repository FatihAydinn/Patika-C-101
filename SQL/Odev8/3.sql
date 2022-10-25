UPDATE employee
SET
	name = 'Sabahattin',
	birthday = '1907-02-25',
	email = 'sali@gmail.com'
WHERE id = 7
RETURNING *;
