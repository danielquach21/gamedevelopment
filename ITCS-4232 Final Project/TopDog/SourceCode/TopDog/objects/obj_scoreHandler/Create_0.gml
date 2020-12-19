if(currentRoom == mg_TailWag){
	player1.tailWags = 0;
	player2.tailWags = irandom(50) + 20;
	player3.tailWags = irandom(50) + 20;
	player4.tailWags = irandom(50) + 20;
	alarm[2] = 15*room_speed;

}else if(currentRoom == mg_RedOrBlack){
	player1.guesses = 0;
	player2.guesses = irandom(9);
	player3.guesses = irandom(9);
	player4.guesses = irandom(9);
	alarm[0] = 45 * room_speed;
}else if(currentRoom == mg_DogJam){
	player1.danceMoves = 0;
	player2.danceMoves = irandom(50) + 20;
	player3.danceMoves = irandom(50) + 20;
	player4.danceMoves = irandom(50) + 20;
	alarm[1] = 30*room_speed;
}
	
