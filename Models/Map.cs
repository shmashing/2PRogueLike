using System.Windows.Input;

namespace Woods.Models {
    public class Map {

        public static int MAP_WIDTH = 30;
        public static int MAP_HEIGHT = 20;
        public Tile[][] map = new Tile[MAP_HEIGHT][];
    
        public Map(){
            for(int i=0; i< MAP_HEIGHT; i++){

                Tile[] row = new Tile[MAP_WIDTH];

                for(int j=0; j<MAP_WIDTH; j++){

                    Tile new_tile = new Tile();

                    if(i==0 || i==MAP_HEIGHT-1){
                        new_tile.type = "wall";
                    }
                    else if(j==0 || j==MAP_WIDTH-1){
                        new_tile.type = "wall";
                    }
                    else {
                        new_tile.type = "ground";
                    }
                    row[j] = new_tile;
                }
                this.map[i] = row;
            }
        }
    }
}