#include <iostream>

#include "utilities.h"

using namespace HOI4ModTool;

int main(int    argc,
         char   *argv[])
{
    println(concatStrings(concatStrings(programInfo.NAME, " v"), programInfo.VERSION));
    return 0;
}
