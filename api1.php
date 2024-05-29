<?php
header("Content-Type: application/json");

$host = '127.0.0.1';
$db = 'barangay_info_system';
$user = 'root';
$pass = '09092902988';
$charset = 'utf8mb4';

$dsn = "mysql:host=$host;dbname=$db;charset=$charset";
$options = [
    PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
    PDO::ATTR_EMULATE_PREPARES => false,
];

$pdo = new PDO($dsn, $user, $pass, $options);

if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    $stmt = $pdo->query("SELECT event_name, event_date, event_description, barangay_id FROM BarangayEvents");
    $events = $stmt->fetchAll();
    echo json_encode($events);

} elseif ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $input = json_decode(file_get_contents('php://input'), true);
    
    // Check if the required keys exist
    if (isset($input['event_name']) && isset($input['event_date']) && isset($input['event_description']) && isset($input['barangay_id'])) {
        $sql = "INSERT INTO BarangayEvents (event_name, event_date, event_description, barangay_id) VALUES (?, ?, ?, ?)";
        $stmt = $pdo->prepare($sql);
        $stmt->execute([$input['event_name'], $input['event_date'], $input['event_description'], $input['barangay_id']]);
        echo json_encode(['message' => 'Event added successfully']);
    } else {
        echo json_encode(['error' => 'Missing required fields']);
    }
}