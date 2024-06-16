pipeline {
    agent any
    tools {
        msbuild 'MSBuild2022'
    }
    stages {
        stage('Build') {
            steps {
                script {
                    bat 'UnitTestProject1.sln /p:Configuration=Release %MSBUILD_ARGS%'
                }
            }
        }
    }
}