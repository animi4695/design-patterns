
public class MoveBehaviour {
    public void Move(int x, int y){
        motor_x(x);
        motor_y(y);
    }
}

public class CleanBehaviour {
    private MoveBehaviour moveBehaviour;
    public void clean(string roomName){
        // clean the room logic
        int x, y = find_room(roomName);
        moveBehaviour.Move(x, y);
    }
}

public class ReadBehaviour {
    public void read(string bookName){
        // read book logic
    }
}

public class Robot : MoveBehaviour {
    // ....
}

public class CustomRobot1 : Robot, CleanBehaviour {
    // This robot can clean now
}

public class CustomRobot2: Robot, ReadBehaviour {
    // This robot can read now. doesn't have to clean.
}