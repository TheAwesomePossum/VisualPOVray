import os, os.path

numFrames = 0

while(os.path.exists("frame" + str(numFrames+1) + ".png")):
        numFrames += 1

print numFrames

for i in range(numFrames):
    os.system("povray frame" + str(i+1) + ".pov &")
