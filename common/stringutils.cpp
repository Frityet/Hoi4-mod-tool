//
// Created by frityet on 2021-08-25.
//

#include <sstream>
#include "stringutils.h"

string concatStrings(string str1, string str2)
{
    std::stringstream stream;
    stream << str1 << str2;
    return stream.str();
}
