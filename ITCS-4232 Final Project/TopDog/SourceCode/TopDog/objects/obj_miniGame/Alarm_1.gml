/// @description Insert description here
// You can write your code in this editor

switch(image_index){
	case 0:
		currentRoom = mg_DogJam;
		room_goto(loading_DogJam);
		started = true;
		
		break;
	case 1:
		currentRoom = mg_RedOrBlack;
		room_goto(loading_RedOrBlack);
		started = true;
		break;
	case 2:
		currentRoom = mg_TailWag;
		room_goto(loading_TailWag);
		started = true;
		break;
}