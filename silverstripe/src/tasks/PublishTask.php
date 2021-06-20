<?php

require 'vendor/autoload.php';

use SilverStripe\Dev\BuildTask;
use SilverStripe\Control\HTTPRequest;

namespace Publisher;

class PublishTask extends BuildTask
{
	private static $segment = 'PublishTask';

    protected $title = 'Publish Task';
    protected $description = 'A task used for publishing content directly to the blog';
    protected $enabled = true;

    public function run(HTTPRequest $request){
        
    }
}