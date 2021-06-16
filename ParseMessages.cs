-- Write only the SQL statement that solves the problem and nothing else
CREATE PROCEDURE ParseMessages AS
BEGIN
  INSERT INTO notifications(id, message)
  SELECT id, data FROM messages
  WHERE type LIKE '%notification%'

  INSERT INTO alerts(id, shortMessage)
  SELECT id, LEFT(data, 15) FROM messages
  WHERE type LIKE '%alert%'
END;
