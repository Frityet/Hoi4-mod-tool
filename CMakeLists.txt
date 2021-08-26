cmake_minimum_required(VERSION 3.19)
project(Hoi4_mod_tool)

set(CMAKE_CXX_STANDARD 20)

add_executable(Hoi4_mod_tool main.cpp common/metadata.h utilities.h common/logging.cpp common/logging.h common/stringutils.cpp common/stringutils.h)