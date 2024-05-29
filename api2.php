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
    $stmt = $pdo->query("SELECT project_name, project_description, project_budget, start_date, end_date, proj_status, barangay_id FROM BarangayProjects");
    $users = $stmt->fetchAll();
    echo json_encode($users);
    $jsonResponse .= "\n";

} elseif ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $input = json_decode(file_get_contents('php://input'), true);
    $sql = "INSERT INTO BarangayProjects (project_name, project_description, project_budget, start_date, end_date, proj_status, barangay_id) VALUES (?, ?, ?, ?, ?, ?, ?)";
    $stmt = $pdo->prepare($sql);
    $stmt->execute([$input['project_name'], $input['project_description'], $input['project_budget'], $input['start_date'], $input['end_date'], $input['proj_status'], $input['barangay_id']]);
    echo json_encode(['message' => 'User added successfully']);
}