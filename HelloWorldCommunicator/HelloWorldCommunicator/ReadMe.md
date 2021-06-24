#Assumptions:
- Given the project context as a message communicator, the API will communicate text messages to outside platforms through REST calls.
- Given the use of 'Write' in line C, I assume we need to write text messages to any output from this Console App, not through the medium of logging.

#Choices:
- Rather than using configuration files to swap between message write output, which would require a complete implementation of all possible configuration possibilities, I chose to write a contract and an implemention specific to a Console App. One could write a separate implementation to write to a database in the future.