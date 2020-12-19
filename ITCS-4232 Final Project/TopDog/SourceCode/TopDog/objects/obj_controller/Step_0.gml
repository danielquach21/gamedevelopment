key_left = keyboard_check(vk_left);
key_right = keyboard_check(vk_right);
key_up = keyboard_check_pressed(vk_up);
key_down = keyboard_check_pressed(vk_down);
key_jump = keyboard_check_pressed(vk_space);


keyA = keyboard_check_pressed(ord("A"));
keyF = keyboard_check_pressed(ord("F"));
keyS = keyboard_check_pressed(ord("S"));
keyD = keyboard_check_pressed(ord("D"));
key_select = gamepad_button_check_pressed(0,gp_select);


if (key_left) || (key_right) || (key_jump)
{
 controller = 0;	
}

if (abs(gamepad_axis_value(0,gp_axislh)) > 0.2)
{
	key_left = abs(min(gamepad_axis_value(0,gp_axislh), 0));
	key_right = max(gamepad_axis_value(0,gp_axislh),0);
	controller = 1;
}

if(gamepad_button_check_pressed(0,gp_padu))
{
	key_up = 1;
	controller = 1;
}

if(gamepad_button_check_pressed(0,gp_padd))
{
	key_down = 1;
	controller =1;
}

if (gamepad_button_check_pressed(0,gp_face1))
{
	key_jump = 1;
	controller = 1;
}

if (gamepad_button_check_pressed(0,gp_face3))
{
	keyA = 1;
	controller = 1;

}

if (gamepad_button_check_pressed(0,gp_face4))
{
	keyF = 1;
	controller = 1;

}

if (gamepad_button_check_pressed(0,gp_face2))
{
	keyS = 1;
	controller = 1;

}

if(key_select){
	   if window_get_fullscreen()
      {
      window_set_fullscreen(false);
      }
   else
      {
      window_set_fullscreen(true);
      }
}

if(instance_exists(obj_gameMode)){
if(obj_gameMode.image_index == 0){
	gameMode = 1;
}else if(obj_gameMode.image_index == 1){
	gameMode = 3;
}else if(obj_gameMode.image_index ==2){
	gameMode = 5;
}
}
