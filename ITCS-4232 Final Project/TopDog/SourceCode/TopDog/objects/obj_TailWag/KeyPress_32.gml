/// @description Insert description here
// You can write your code in this editor
counter++;
if(counter == 1){
	image_index = 1;
}else if(counter == 2){
	image_index = 2;
}else if(counter == 3){
	image_index = 3;
}else if(counter == 4){
	image_index = 2;
}else if(counter == 5){
	image_index = 1;
	counter = 0;
}
	
audio_play_sound(tailwag, 1, false);